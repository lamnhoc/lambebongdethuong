using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace LEXUANLAM_LAB45.ViewModels
{
    public class FutureDate :ValidationAttribute
    {
        private bool isValib;

        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
            "dd/M/yyyy",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);

            return (isValib && dateTime > DateTime.Now);
        }
    }
}