using AccountService.Business.DTOs;
using Microsoft.AspNetCore.Identity;

namespace AccountService.Business.Interfaces;

public interface IAuthService
{
    Task<SignInResult> SignInAsync(SignInDto formData);
    Task<SignUpResult> SignUpAsync(SignUpDto formData);
}