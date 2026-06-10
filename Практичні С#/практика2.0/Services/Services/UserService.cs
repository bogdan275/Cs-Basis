using Data.Models;
using Repositories.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepo;
        private readonly EmployeeRepository _employeeRepo;

        public UserService(UserRepository userRepo, EmployeeRepository employeeRepo)
        {
            _userRepo = userRepo;
            _employeeRepo = employeeRepo;
        }

        public User Authenticate(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Login and password are required");
            }

            var user = _userRepo.Authenticate(login, password);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid login or password");
            }

            if (!user.IsActive)
            {
                throw new UnauthorizedAccessException("This account is deactivated");
            }


            return user;
        }

        public void Register(string login, string password, string role, int? employeeId = null)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentException("Login is required");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is required");
            }

            if (password.Length < 4)
            {
                throw new ArgumentException("Password must be at least 4 characters long");
            }

            if (role != "Administrator" && role != "TechnicalSpecialist")
            {
                throw new ArgumentException("Role must be 'Administrator' or 'TechnicalSpecialist'");
            }

            if (_userRepo.LoginExists(login))
            {
                throw new ArgumentException("This login is already taken");
            }

            var user = new User
            {
                Login = login,
                Password = password,
                Role = role,
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _userRepo.Add(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepo.GetById(id);
        }

        public void UpdateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Login))
            {
                throw new ArgumentException("Login is required");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Password is required");
            }

            var existingUser = _userRepo.GetByLogin(user.Login);
            if (existingUser != null && existingUser.UserId != user.UserId)
            {
                throw new ArgumentException("This login is already taken by another user");
            }

            _userRepo.Update(user);
        }

        public void DeleteUser(int userId)
        {
            _userRepo.Delete(userId);
        }

        public void DeactivateUser(int userId)
        {
            var user = _userRepo.GetById(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            user.IsActive = false;
            _userRepo.Update(user);
        }

        public void ActivateUser(int userId)
        {
            var user = _userRepo.GetById(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            user.IsActive = true;
            _userRepo.Update(user);
        }
    }
}
