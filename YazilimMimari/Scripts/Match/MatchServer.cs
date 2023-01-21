using System;
using YazilimMimari.Scripts.ObserverPattern;

namespace YazilimMimari.Scripts.Match
{
	public class MatchServer : IMatchResponsePublisher
	{

        private List<IMatchResponseObserver> matchResponseObservers;

		public MatchServer()
		{
            matchResponseObservers = new List<IMatchResponseObserver>();
        }

        public MatchResponseInfo AiPlayerMatchModel(MatchRequest matchRequest)
        {
            NotifyMatchResonseObservers(true);
            return new MatchResponseInfo();
        }
       

        public void NotifyMatchResonseObservers(bool isPlayerMatch)
        {
            if (matchResponseObservers.Count < 1)
                return;

            foreach (var observer in matchResponseObservers)
            {
                observer.NotifIsPlayerMatch(true);
            }
        }

        public void Register(IMatchResponseObserver observer)
        {
            if (matchResponseObservers.Contains(observer))
                return;
            matchResponseObservers.Add(observer);
        }

        public void UnRegister(IMatchResponseObserver observer)
        {
            if (!matchResponseObservers.Contains(observer))
                return;
            matchResponseObservers.Remove(observer);
        }
    }
}

