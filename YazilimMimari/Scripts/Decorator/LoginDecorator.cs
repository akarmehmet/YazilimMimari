using System;
using YazilimMimari.Scripts.UserAuthenticate;
using YazilimMimari.Scripts.Users;

namespace YazilimMimari.Scripts.Decorator
{
    public class LoginDecorator : UserDecorator, ILogin
    {
        public LoginDecorator(PlayerData playerData) : base(playerData)
        {
        }

        public override void Authenticate()
        {
            base.Authenticate();
            Login("admin@gmail.com", "admin123");
        }

        public bool IsLoggedIn()
        {
            return playerData.IsRegisteredPlayer;
        }

        public bool Login(string email, string password)
        {
            return playerData.mail.Equals(email) && password == "admin123";
        }
    }
}

