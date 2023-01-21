using System;
namespace YazilimMimari.Scripts.Users
{
	public class ConcreteUser : User
	{
        public ConcreteUser(PlayerData playerData) : base(playerData)
        {
        }

        public override void Authenticate()
        {
            playerData = PlayerData.Instance;

        }
    }
}

