using System.ComponentModel.DataAnnotations;

namespace RoutingUygulama.Attributes
{
    //public class YasSiniriAttribute : ValidationAttribute
    //{
    //    public YasSiniriAttribute(int yas, int yas2)
    //    {

    //        Yas = yas;
    //        Yas2 = yas2;
    //    }
    //    public int Yas { get; }
    //    public int Yas2 { get; }
    //    public string HataMesaji { get; set; } = "Yasiniz gecersizdir.";

    //    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    //    {
    //        DateTime? tarih = value as DateTime?;



    //        if (tarih != null && YasHesapla(tarih.Value) < Yas && Yas2 < YasHesapla(tarih.Value))
    //        {
    //            return new ValidationResult(HataMesaji);
    //        }
    //        return ValidationResult.Success;
    //    }

    //    private int YasHesapla(DateTime value)
    //    {
    //        DateTime bugun = DateTime.Today;
    //        int yas = bugun.Year - value.Year;

    //        if (value.Month > bugun.Month || value.Month == bugun.Month && value.Day > bugun.Day)
    //        {
    //            return yas - 1;
    //        }

    //        return yas;
    //    }
    //}
}
