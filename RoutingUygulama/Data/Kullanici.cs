using RoutingUygulama.Attributes;
using System.ComponentModel.DataAnnotations;

namespace RoutingUygulama.Data
{
    public class Kullanici
    {
        [Range(18,100,ErrorMessage ="Gecersiz Yas araligi girdiniz")]
        public int Yas { get; set; }
        [MinLength(2)]
        [MaxLength(4)]
        public string DaireNo { get; set; } = null!;
        
        public string Sifre { get; set; } = null!;
        [Compare("Sifre")]
        public string SifreTekrari { get; set; } = null!;
        [SicilNo(ErrorMessage = "Gecersiz sicil numarasi formati.")]
        public string SicilNo { get; set; } = null!;

    }
}
