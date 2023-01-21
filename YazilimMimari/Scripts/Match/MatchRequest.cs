using System;
using YazilimMimari.Scripts.Users;
using YazilimMimari.Scripts.Utilities;

namespace YazilimMimari.Scripts.Match
{
	public class MatchRequest
	{
		public Games game;
		public PlayerData playerData;
		private MatchServer matchServer;

		public MatchRequest(Games _game,MatchServer matchServer)
		{
			game = _game;
			playerData = PlayerData.Instance;
			this.matchServer = matchServer;
		}

		public MatchResponseInfo MakeRequest(Games game, PlayerData playerInfo)
		{
			return matchServer.AiPlayerMatchModel(this);
		}
    }
}

