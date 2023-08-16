using System.ComponentModel.DataAnnotations;

namespace RoutingUygulama.Attributes
{
    public class SicilNoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var sicilNo = value.ToString();

            if (sicilNo.Length != 8)
                return false;

            else if (!int.TryParse(sicilNo.Substring(0, 4), out int yil))
                return false;

            else if (yil < 2000 || yil > 2023)
                return false;

            else if (!"ABCDE".Contains(sicilNo[4]))
                return false;

            else if (!int.TryParse(sicilNo.Substring(5), out int sonBasamak))
                return false;

            else if (sonBasamak < 1 || sonBasamak > 999)
                return false;
            else
            return true;
        }

        
    }
}
