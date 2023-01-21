using System;
using YazilimMimari.Scripts.Users;

namespace YazilimMimari.Scripts.UserAuthenticate
{
	public interface IRegister
	{
		Task<bool> Register(PlayerData pLayerData);
	}
}

