using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class RentalMessages
    {
        public static string RentalAdded = "Araba kiralandı.";
        public static string RentalDeleted = "Kiralık araba silindi.";
        public static string RentalUpdated = "Kiralık araba güncellendi.";

        public static string RentalNotAdded = "Araba kiralanamadı.";
        public static string RentalNotDeleted = "Kiralık araba silinemedi.";
        public static string RentalNotUpdated = "Kiralık araba güncellenemedi.";

        public static string RentalListed = "Kiralık arabalar listelendi.";
        public static string RentalGet = "Kiralık araba getirildi.";
        
    }
}
