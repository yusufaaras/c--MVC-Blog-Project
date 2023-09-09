using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCegitimi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        [EmailAddress()]
        public string Email { get; set; }

        public string Telefon { get; set; }
        [Required,DisplayName("Tc Kimlik Numarası")] //ekranda yazması gereken yoksa TcKimlikNo yazar
        [MinLength(11,ErrorMessage ="Tc kimlik numarası minimum 11 karakter olmalıdır")]
        [MaxLength(11, ErrorMessage = "Tc kimlik numarası maksimum 11 karakter olmalıdır")]
        public string TcKimlikNo { get; set; }
        [Required]
        [DisplayName("şifre Tekrar"),DataType(DataType.Password)]
        [Compare("sifre")]
        public int SifreTekrar { get; set; }
        public string KullaniciAdi { get; set; }
        [Required]
        [DisplayName("sifre"),DataType(DataType.Password)]
        [StringLength(100,MinimumLength =5)]
        public string Sifre { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}"),DisplayName("DOğum Tarihi"),DataType(dataType:DataType.Date)]
        public DateTime DogumTarihi { get; set; }
    }
}