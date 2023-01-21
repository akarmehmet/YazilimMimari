using System;
using YazilimMimari.Scripts.ObserverPattern;

namespace YazilimMimari.Scripts.Users
{

	public abstract class User:IMatchResponseObserver
	{

		public PlayerData playerData;

        public User(PlayerData playerData)
        {
            this.playerData = playerData;
        }

		public abstract void Authenticate();

        public void NotifIsPlayerMatch(bool isPlayerMatch)
        {
            playerData.IsPlayerInGame = isPlayerMatch;
        }
    }
}

