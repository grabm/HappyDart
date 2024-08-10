using HappyDart.Domain.Abstractions;
using MediatR;

namespace HappyDart.Application.Players.AddPlayer;

public record AddPlayerCommand(string Name, string Email, string Password) : IRequest<Result>;