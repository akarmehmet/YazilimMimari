using System;
using YazilimMimari.Scripts.Users;

namespace YazilimMimari.Scripts.Decorator
{
	public abstract class UserDecorator : User
	{
        protected User user;

        protected UserDecorator(PlayerData playerData) : base(playerData)
        {
        }

        public override void Authenticate()
        {
            if(user != null)
            {
                user.Authenticate();
            }
        }

        public void SetTheUser(User user)
        {
            this.user = user;
        }
    }
}

