using System;
using YazilimMimari.Scripts.ObserverPattern;
using YazilimMimari.Scripts.Singletons;
using YazilimMimari.Scripts.Utilities;
using static YazilimMimari.Scripts.Utilities.Enums;

namespace YazilimMimari.Scripts.Users
{
	public class PlayerData :Singleton<PlayerData>,IMatchResponseObserver
    {
		public int yas { get; set; }
        public float experience { get; set; }
        public string providerInfo { get; set; }
        public string mail { get; set; }
        public bool IsRegisteredPlayer { get; set; }
        public bool IsPlayerInGame { get; set; }
		public Gender gender { get; set; }
		public List<Games> games { get; set; }

        public void NotifIsPlayerMatch(bool isPlayerMatch)
        {
            IsPlayerInGame = isPlayerMatch;
        }

        
    }
}

