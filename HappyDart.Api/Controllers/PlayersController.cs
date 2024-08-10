using HappyDart.Api.Shared.Requests;
using HappyDart.Api.Shared.Responses;
using HappyDart.Application.Players.AddPlayer;
using HappyDart.Application.Players.SignIn;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HappyDart.Api.Controllers;

[ApiController]
[Route("api/players")]
public class PlayersController : ControllerBase
{
    private readonly ISender _sender;

    public PlayersController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("singIn")]
    public async Task<IActionResult> SingIn(LogInRequest logInRequest, CancellationToken cancellationToken)
    {
        var logInQuery = new SignInQuery(logInRequest.Email, logInRequest.Password);
        var logInResponse = await _sender.Send(logInQuery, cancellationToken);

        return Ok(logInResponse);
    }

    [HttpPost]
    public async Task<IActionResult> AddPlayer(CreatePlayerRequest  createPlayerRequest, CancellationToken cancellationToken)
    {
        var addPlayerCommand = new AddPlayerCommand(createPlayerRequest.Name, createPlayerRequest.Email, createPlayerRequest.Password);
        var result = await _sender.Send(addPlayerCommand, cancellationToken);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> RemovePlayer(CancellationToken cancellationToken)
    {
        return await Task.FromResult(Ok());
    }
}