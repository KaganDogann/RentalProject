using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class CustomerMessages
    {
        public static string CustomerAdded = "Yeni müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CustomerGet = "Müşteri bilgileri getildi.";

        public static string CustomerNotAdded = "Yeni müşteri eklenemedi.";
        public static string CustomerNotDeleted = "Müşteri silinemedi.";
        public static string CustomerNotUpdated = "Müşteri güncellenemedi";
        public static string CustomerNotListed = "Müşteriler listelenemedi.";
        public static string CustomerNotGet = "Müşteri bilgileri getilemedi.";
    }
}
