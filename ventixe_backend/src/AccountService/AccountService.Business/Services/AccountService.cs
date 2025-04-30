using AccountService.Business.DTOs;
using Microsoft.AspNetCore.Identity;

namespace AccountService.Business.Services;

public class AccountService
{
    private readonly UserManager<IdentityUser> _userManager;

    public async Task<AccountDto> GetAccountByIdAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
            return null;

        return new AccountDto
        {
            Id = user.Id,
            Email = user.Email,
            UserName = user.UserName
        };
    }

}
