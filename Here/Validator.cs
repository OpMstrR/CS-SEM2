using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Validnost
    {
        public delegate bool Validator(string smth);

        internal static Validator GetValidator(int minLength)
        {
            return ryadok => ( ryadok.Length >= minLength );
        }
    }
}
