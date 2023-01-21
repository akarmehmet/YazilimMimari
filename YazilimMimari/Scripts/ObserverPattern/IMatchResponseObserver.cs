using System;
namespace YazilimMimari.Scripts.ObserverPattern
{
	public interface IMatchResponseObserver
	{
        void NotifIsPlayerMatch(bool isPlayerMatch);
    }
}

