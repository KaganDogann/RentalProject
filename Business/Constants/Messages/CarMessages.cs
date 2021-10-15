using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class CarMessages
    {
        public static string CarAdded="Araba eklendi:";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba bilgisi güncellendi.";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNotAdded = "Araba Eklenemedi. Araba ismi geçersiz.";
        public static string CarNotUpdated = "Araba Güncellenemedi";
        public static string CarNotDeleted = "Araba Silinemedi";
        public static string CarCantFind = "güncellenecek Araba bulunamadı";
        public static string CarDetailList = "Araba Detay Listesi";
        public static string CarCountOfOpelError = "Opel Marka Araçtan 2 den fazla olamaz.";
    }
}
