using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavaoriteMoviesApp.Helpers.Validators
{
    public static class MovieValidator
    {
        public static bool ValidateTitle(string title)
        {
            if (title != string.Empty || title != null)
            {
                return true;
            }
            return false;
        }
    }
}
