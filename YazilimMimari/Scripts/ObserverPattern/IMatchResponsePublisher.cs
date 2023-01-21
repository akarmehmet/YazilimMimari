using System;
namespace YazilimMimari.Scripts.ObserverPattern
{
	public interface IMatchResponsePublisher
    {
        void Register(IMatchResponseObserver observer);
        void UnRegister(IMatchResponseObserver observer);
        void NotifyMatchResonseObservers(bool isPlayerMatch);

    }
}

