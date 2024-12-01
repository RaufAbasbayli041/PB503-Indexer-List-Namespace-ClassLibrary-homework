using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PB503Helper
{
    public static class Helper
    {
        public static string CreateBookCode(string bookName, byte number)
        {
            string bookUpper = string.Empty;

            if (!string.IsNullOrEmpty(bookName) && !string.IsNullOrWhiteSpace(bookName))
            {
                bookUpper = bookName.Substring(0, 2).ToUpper();
            }
            return bookUpper + 0 + number;
        }


    }
}
