using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class ColorMessages
    {
        public static string ColorAdded = "Yeni renk eklendi.";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorListed = "Renkler listelendi.";
        public static string ColorGet = "Renk getirildi.";

        public static string ColorNotAdded = "Yeni renk eklenemedi.";
        public static string ColorNotDeleted = "Renk silinemedi";
        public static string ColorNotUpdated = "Renk güncellenemedi";
        public static string ColorNotListed = "Renkler listelenemedi.";
        public static string ColorNotGet = "Renk getirilemedi.";
    }
}
