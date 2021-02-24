using System;
using System.Collections.Generic;
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
    }
}
