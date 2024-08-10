using HappyDart.Api.Shared.Responses;
using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Users;
using MediatR;

namespace HappyDart.Application.Players.SignIn;

public class SignInQueryHandler : IRequestHandler<SignInQuery, Result<LogInResponse>>
{
    private readonly IPlayerRepository _playerRepository;

    public SignInQueryHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }
    public async Task<Result<LogInResponse>> Handle(SignInQuery request, CancellationToken cancellationToken)
    {
        var player = await _playerRepository.GetByCredentialsAsync(request.Email, request.Password);

        bool loginSuccess = player is not null;
        bool isUserActive = player is not null ? player.User.IsActive : false;

        var loginResponse = new LogInResponse(player?.User.Email, isUserActive, loginSuccess);

        return Result.Success(loginResponse);
    }
}