using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
	public static class MyMessages
	{

		
		public static string ProductAdded = "Ürün Eklendi";
		public static string ProductNameInvalid = "Ürün ismi geçersiz";
		public static string MaintenanceTime = "Sistem Bakımda";
		public static string ProductsListed = "Ürünler Listelendi";
		public static string ProductCountError = "15 adet ürün miktarını geçtiniz";
		public static string ProductNameError = "Ürün adı zaten mevcut";
		public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
		public static string AuthorizationDenied = "Yetkiniz Yok";
		public static string UserRegistered = "Kullanıcı kayıt edildi";
		//public static User UserNotFound = "Kullanıcı bulunamadı";
		//public static User PasswordError = "Hatalı parola";
		public static string SuccessfulLogin = "Giriş başarılı";
		public static string UserAlreadyExists = "Kullanıcı zaten var";
		public static string AccessTokenCreated = "Token oluşturuldu";

		public static string ProductNameCannotEmpty = "Ürün Adı Boş Olamaz";
		public static string ProductNameLengthInvalid = "Ürün Adı 2 karakterden küçük olamaz";
		public static string ProductCountOfCategoryError = "Mevcut Kategori için ürün limiti aşıldı";
		public static string ProductNameAldreadyExist = "Ürün Adı Zaten Mevcut";
	}
}
