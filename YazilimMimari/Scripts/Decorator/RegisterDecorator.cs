using System;
using YazilimMimari.Scripts.UserAuthenticate;
using YazilimMimari.Scripts.Users;

namespace YazilimMimari.Scripts.Decorator
{
	public class RegisterDecorator : UserDecorator,IRegister
	{
        public RegisterDecorator(PlayerData playerData) : base(playerData)
        {
        }

        public override void Authenticate()
        {
            base.Authenticate();
            Register(playerData);
        }

        public async Task<bool> Register(PlayerData pLayerData)
        {
            return await SaveUserInfo();
        }


        private async Task<bool> SaveUserInfo()
        {
            playerData.gender = Utilities.Enums.Gender.Man;
            playerData.IsPlayerInGame = false;
            playerData.providerInfo = "google";
            playerData.experience = 0;
            playerData.mail = "admin@gmail.com";
            playerData.yas = 21;
            playerData.games = new List<Utilities.Games>();
            playerData.IsRegisteredPlayer = true;

            return true;
        }
    }
}

