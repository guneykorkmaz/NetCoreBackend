using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarPriceInvalid = "Araba fiyatı sıfırdan büyük olmalı";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarNotAvailable = "Araba kirada";
        public static string RentAdded = "Araba kiralandı";
        public static string CarImageLimitExceeded = "Bir arabanın en fazla beş fotoğrafı olabilir";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı";
        public static string PasswordError = "Parola hatalı";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
