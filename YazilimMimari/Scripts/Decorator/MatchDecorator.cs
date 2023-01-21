using System;
using YazilimMimari.Scripts.Match;
using YazilimMimari.Scripts.ObserverPattern;
using YazilimMimari.Scripts.Users;
using YazilimMimari.Scripts.Utilities;

namespace YazilimMimari.Scripts.Decorator
{
	public class MatchDecorator : UserDecorator, IMatchResponseObserver
	{
        private MatchRequest matchRequest;
        private PlayerData playerData;
        private bool isPlayerInMatch;
        private Games game;

		public MatchDecorator(PlayerData playerData, MatchRequest matchRequest) :base(playerData)
		{
            this.matchRequest = matchRequest;
            playerData = PlayerData.Instance;
            game = matchRequest.game;
		}

        public void NotifIsPlayerMatch(bool isPlayerMatch) => isPlayerInMatch = isPlayerInMatch;

        public override void Authenticate()
        {
            base.Authenticate();
            MatchRequest(game,playerData);
        }

        private MatchResponseInfo MatchRequest(Games game, PlayerData playerInfo)
        {
           return  matchRequest.MakeRequest(game, playerData);
        }
    }
}

