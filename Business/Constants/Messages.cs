using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // staticler nevlenmez
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="En fazla on ürün olmalıdır.";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetkiniz yok";
    }
}
