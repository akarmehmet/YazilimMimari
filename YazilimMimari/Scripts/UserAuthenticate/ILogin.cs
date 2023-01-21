using System;
namespace YazilimMimari.Scripts.UserAuthenticate
{
	public interface ILogin
	{
		bool Login(string email, string password);
		bool IsLoggedIn();
	}
}

