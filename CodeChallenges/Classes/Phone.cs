using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges.Classes
{
    class Phone
    {
        private string[] phoneNumbers = { "123-647-EYES", "(325)444-TEST", "653-TRY-THIS" };

        public Phone()
        {
            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(Conversion(number));
            }

        }

        public static string Conversion(string phone)
        {
            char[] phoneAsChars = phone.ToCharArray();
            int index = 0;
            foreach (char c in phoneAsChars)
            {
                if (c == 'A' || c == 'B' || c == 'C')
                {
                    phoneAsChars[index] = '2';
                }
                else if (c == 'D' || c == 'E' || c == 'F')
                {
                    phoneAsChars[index] = '3';
                }
                else if (c == 'G' || c == 'H' || c == 'I')
                {
                    phoneAsChars[index] = '4';
                }
                else if (c == 'J' || c == 'K' || c == 'L')
                {
                    phoneAsChars[index] = '5';
                }
                else if (c == 'M' || c == 'N' || c == 'O')
                {
                    phoneAsChars[index] = '6';
                }
                else if (c == 'P' || c == 'Q' || c == 'R' || c == 'S')
                {
                    phoneAsChars[index] = '7';
                }
                else if (c == 'T' || c == 'U' || c == 'V')
                {
                    phoneAsChars[index] = '8';
                }
                else if (c == 'W' || c == 'X' || c == 'Y' || c == 'Z')
                {
                    phoneAsChars[index] = '9';
                }

                index++;
            }
            string updatedPhone = new string(phoneAsChars);
            return updatedPhone;
        }
    }
}
