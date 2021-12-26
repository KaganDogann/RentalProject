using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService//Bu servis sayesinde sisteme giriş yapıcam veya  kayıt olucam
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password); //Kayıt operasyonu
        IDataResult<User> Login(UserForLoginDto userForLoginDto);//Giriş operasyonu
        IResult UserExists(string email);//Kullanıcı var mı
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
