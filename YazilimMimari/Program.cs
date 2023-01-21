using YazilimMimari.Scripts.Decorator;
using YazilimMimari.Scripts.Match;
using YazilimMimari.Scripts.Users;
using YazilimMimari.Scripts.Utilities;

namespace YazilimMimari;
class Program
{
    static void Main(string[] args)
    {
        PlayerData playerData = PlayerData.Instance;

        ConcreteUser user = new ConcreteUser(playerData);


        // Register User
        RegisterDecorator registerDecorator = new RegisterDecorator(playerData);
        registerDecorator.SetTheUser(user);
        registerDecorator.Authenticate();

        // Login User

        LoginDecorator loginDecorator = new LoginDecorator(playerData);
        loginDecorator.SetTheUser(registerDecorator);
        loginDecorator.Authenticate();

        // Match Request

        Games game = new Games()
        {
            Name = "Dota2",
            Type = "PVP",
            Id = "123"

        };

        MatchServer matchServer = new MatchServer();
        MatchRequest matchRequest = new MatchRequest(game, matchServer);

        MatchDecorator matchDecorator = new MatchDecorator(playerData,matchRequest);
        matchDecorator.SetTheUser(loginDecorator);
        matchDecorator.Authenticate();




    }
}

