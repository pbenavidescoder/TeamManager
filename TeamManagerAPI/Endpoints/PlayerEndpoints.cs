using TeamManagerAPI.Domain;
using TeamManagerAPI.Services;

namespace TeamManagerAPI.Endpoints
{
    public static class PlayerEndpoints
    {
        public static void MapPlayerEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/players", (PlayerService service) => service.GetPlayers());
            routes.MapPost("/players", (PlayerService service, Player player) => service.AddPlayer(player));
            // PUT y DELETE similares
        }


    }
}
