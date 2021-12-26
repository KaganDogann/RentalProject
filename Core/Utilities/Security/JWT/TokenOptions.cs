namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {   //Web API de appsettings kısımlarında token options sekmem var. orada ki değerlerle buradaki değerleri eşlemem gerekecek. daha nesnel çalışmak için
        //Bir JWT üretmenin çeşitli standartları var bizim bunları veriyor olmamız gerekiyor. Sade bir şekilde şundan bahsediyorum. appsetting içerisinde ki verilere
        // JWT oluştururken ihtiyacım var. bende orada ki değerleri bu nesnemile mapp edip 'CreateToken' yaparken kullanacağım
        public string Audience { get; set; }//Bizim token'ımızın kullanıcı kitlesi
        public string Issuer { get; set; }// imlzayanı
        public int AccessTokenExpiration { get; set; }//Token gerçerlilik süresi 
        public string SecurityKey { get; set; }
    }
}




