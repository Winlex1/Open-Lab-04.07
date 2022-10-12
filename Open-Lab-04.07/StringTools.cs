using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] chars = original.ToCharArray();
            string reversed = String.Empty;
            for(int i = chars.Length - 1; i >= 0; i--)
            {
                reversed += chars[i];
            }
            return reversed;
        }
    }
}
