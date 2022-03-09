using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace Task_2
{
    public class Finder
    {
        private FileInfo _documentHTML;
        private string text;

        private static string patternLinks = @"href\s*=\s*(?:[""'](?<1>[^""']*)[""']|(?<1>\S+))";
        private static string patternTelephone = @"\(\d{3}\) \d{3}-\d{2}-\d{2}|\+\d{2}\d{10}|\+\(\d{2}\)\d{10}";
        private static string patternMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

        public Finder(FileInfo documentHTML)
        {
            if (documentHTML.Extension == ".html")
            {
                _documentHTML = documentHTML;
                StreamReader SR = new StreamReader(_documentHTML.FullName);
                text = SR.ReadToEnd();
            }
                
            else
                throw new ArgumentException($"Document {nameof(documentHTML)} is not a HTML file");
        }

        public List<string> FindLinks()
        {
            List<string> vs = new List<string>();

            foreach (Match item in Regex.Matches(text,patternLinks))
            {
                vs.Add(item.Value);
            }

            return vs;
        }

        public List<string> FindTelephone()
        {
            List<string> vs = new List<string>();

            foreach (Match item in Regex.Matches(text, patternTelephone))
            {
                vs.Add(item.Value);
            }

            return vs;
        }
        public List<string> FindMail()
        {
            List<string> vs = new List<string>();

            foreach (Match item in Regex.Matches(text, patternMail))
            {
                vs.Add(item.Value);
            }

            return vs;
        }
    }
}
