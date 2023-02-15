using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme Başarılı";
        public static string Deleted = "Silme Başarılı";
        public static string Updated = "Güncelleme Başarılı";
        public static string NameInvalid = "Geçersiz İsim";
        public static string Listed = "Listelendi";
       
        public static string GetCar = "Araba gösterildi";
        public static string GetColor = "Renk gösterildi";
        public static string GetBrand = "Renk gösterildi";
        public static string GetCarByBrand = "Markalarına göre araba listelendi";
        public static string GetCarByColor = "Renklerine göre araba listelendi";
        
        public static string GetRentalDetail = "Kiralama detayları gösterildi";
        public static string RentalInvalid = "Araba kiralamaya uygun değildir";
        public static string RentalValid = "Araba kiralama başarılı";
        public static string GetCarImage = "Araba görseli getirildi";
    }
}
