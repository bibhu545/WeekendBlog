using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.DTOs;
using WeekendBlog.Business.Interfaces;
using WeekendBlog.Dataaccess.Interfaces;
using WeekendBlog.Dataaccess.Models;

namespace WeekendBlog.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task AddUser(UserDto userDto)
        {
            User user = new()
            {
                UserId = Guid.NewGuid(),
                UserName = userDto.UserName,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Password = userDto.Password,
                Email = userDto.Email,
                RoleId = userDto.RoleId,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            await _userRepository.AddUser(user);
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {    
            var users = await _userRepository.GetUsers();
            return users.Select(u => new UserDto
            {
                UserId = u.UserId,
                UserName = u.UserName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Password = u.Password,
                Email = u.Email,
                IsActive = u.IsActive,
                CreatedAt = u.CreatedAt,
                UpdatedAt = u.UpdatedAt
            });
        }

        public async Task<UserDto> Login(UserDto userDto)
        {
            var users = await _userRepository.GetUsers();
            var user = users.FirstOrDefault(u => u.UserName == userDto.UserName && u.Password == userDto.Password);
            if (user == null)
            {
                return null;
            }
            else
            {
                var userDtoResult = new UserDto
                {
                    UserId = user.UserId,
                    Token = GenerateJwtToken(user)
                };
          
                return userDtoResult;
            }
        }

        private string GenerateJwtToken(User user)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var keyString = jwtSettings["Key"];
            if (string.IsNullOrEmpty(keyString))
            {
                throw new InvalidOperationException("JWT Key configuration is missing or empty.");
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyString));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.RoleId.ToString())
            };

            var token = new JwtSecurityToken
            (
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["ExpiryInMinutes"])),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
