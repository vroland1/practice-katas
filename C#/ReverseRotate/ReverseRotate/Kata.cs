using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace ReverseRotate
{
    public class Kata
    {
        public string ReverseRotate (string str, int size)
        {
            if (size <= 0 || str == "" || str.Length < size) return "";

            List<string> chunks = new List<string>();
            for (int i = 0; i<str.Length; i+=size)
            {
                try
                {
                    string chunk = str.Substring(i, size);
                    if (chunk.Length >= size) chunks.Add(chunk);
                }
                catch
                {
                    break;
                }               
            }

            string result = "";

            foreach(string chunk in chunks)
            {
                var sum = 0;
                foreach (char number in chunk.ToCharArray())
                {
                    sum += (int)Char.GetNumericValue(number) * (int)Char.GetNumericValue(number);
                }

                if (sum % 2 == 0)
                {
                    result += new string(chunk.ToCharArray().Reverse().ToArray());
                }
                else
                {
                    result += chunk;
                }

            };

            return result;
            
        }
    }
}
