using HappyDart.Domain.Abstractions;
using HappyDart.Domain.Aggregates.Players;
using HappyDart.Domain.Aggregates.Users;
using MediatR;

namespace HappyDart.Application.Players.AddPlayer;

public class AddPlayerCommandHandler : IRequestHandler<AddPlayerCommand, Result>
{
    private readonly IPlayerRepository _playerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddPlayerCommandHandler(IPlayerRepository playerRepository,
        IUnitOfWork unitOfWork)
    {
        _playerRepository = playerRepository;
        _unitOfWork = unitOfWork;
    }


    public async Task<Result> Handle(AddPlayerCommand request, CancellationToken cancellationToken)
    {
        var player = Player.CreateNew(request.Name, request.Email, request.Password);   
        _playerRepository.Add(player.Value);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
}