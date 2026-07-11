using TeamManager.Application.UseCases.Players;


namespace TeamManagerAPI.Endpoints
{
    public static class PlayerEndpoints
    {
        public static void MapPlayerEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/players", async (GetPlayersUseCase useCase) =>
            {
                var players = await useCase.ExecuteAsync();
                return Results.Ok(players);
            });

            //routes.MapPost("/players", (PlayerService service, Player player) => service.AddPlayer(player));
            //// PUT y DELETE similares
        }


    }
}
