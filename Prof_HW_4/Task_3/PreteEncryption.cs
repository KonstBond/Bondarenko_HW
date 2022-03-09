using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_3
{
    public static class PreteEncryption
    {
        private static List<string> _pretex = new List<string>
        {
            "в",
            "без",
            "до",
            "из",
            "к",
            "на",
            "по",
            "о",
            "от",
            "перед",
            "при",
            "через",
            "с",
            "у",
            "за",
            "над",
            "об",
            "под",
            "про",
            "для"
        };

        public static string Encrypt(FileInfo textfile)
        {
            StreamReader SR = new StreamReader(textfile.FullName);
            string text = SR.ReadToEnd();

            string[] word = text.Split(" ");
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (_pretex.Contains(word[i]))
                    word[i] = "ГАВ!";
                result.Append(word[i] + " ");
            }
            return result.ToString();
        }
    }
}

