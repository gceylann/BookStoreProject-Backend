﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult UserExists(string email);
        IResult ChangePassword(UserForChangingPasswordDto userForChangingPasswordDto);

    }
}