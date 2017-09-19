using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public class User
    {
        public Guid UserId { get; protected set; }
        public string Email { get; protected set; }
        public string UserName { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        protected User() { }// packages need ctor without atributes
        public User(string email,string userName,string password,string salt)
        {
            UserId = Guid.NewGuid();
            SetEmail(email);
            UserName = userName;
            SetPassword(password);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException("User need an email");
            if (!email.Contains("@"))
                throw new ArgumentException("Email is not valid, must contain '@'");
            Email = email;

        }
        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("User need a password");
            Password = password;

        }



    }
}
