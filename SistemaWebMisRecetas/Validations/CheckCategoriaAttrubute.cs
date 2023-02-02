using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CheckCategoriaAttrubute:ValidationAttribute
    {
        public CheckCategoriaAttrubute()
        {
            ErrorMessage = "La categoria solo puede ser Desayuno";
        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return true;
            }
            string categoria = value.ToString().ToUpper();
            return (categoria == "DESAYUNO") ? true:false;
        }
    }
}
