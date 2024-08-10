namespace HappyDart.Api.Shared.Responses;

public record LogInResponse(
    string Email,
    bool IsActive,
    bool LoginSuccess);