using HappyDart.Api.Shared.Responses;
using HappyDart.Domain.Abstractions;
using MediatR;

namespace HappyDart.Application.Players.SignIn;

public record SignInQuery(string Email, string Password) : IRequest<Result<LogInResponse>>;