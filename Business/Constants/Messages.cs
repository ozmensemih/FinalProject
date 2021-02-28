using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

// Constants 
namespace Business.Constants
{
    // sabit olduğu için ve new lemek istemediğim için statik tanımlandı.
    //puplic tanımlar büyük harf yazılır pascall keys ProductAdded
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürün listelendi";
        public static string ProductCountOfCategoryError = "Kategoride 10dan fazla ürün olamaz";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün ekli";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı. Ürün eklenemez";

        public static string  AuthorizationDenied = "Yetkin yok";

        public static string UserRegistered = "Kayıt oldu.";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatalı";

        public static string SuccessfulLogin = "Login oldu";

        public static string UserAlreadyExists = "Kullanıcı zaten ekli";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
