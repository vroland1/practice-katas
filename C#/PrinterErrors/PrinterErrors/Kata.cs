using System;
using System.Linq;

namespace PrinterErrors
{
    public class Kata
    {
        public string PrinterError(String s)
        {
            return s.Where(c => c > 'm').Count() + "/" + s.Length;
        }
    }
}
