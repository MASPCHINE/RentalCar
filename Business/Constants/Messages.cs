using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public static string CarImageCountOfImagesLimit="Arabanın maksimum 5 görseli olabilir";

        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserRegistered = "Kayıt olundu";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
