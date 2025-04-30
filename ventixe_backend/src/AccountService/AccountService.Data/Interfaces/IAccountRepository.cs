using AccountService.Data.Entities;

namespace AccountService.Data.Interfaces;

public interface IAccountRepository
{
    Task<AccountEntity?> GetUserByIdAsync(string userId);
}