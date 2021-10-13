using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem
{ 
    public class URLArgumentExtractor
    {
        private readonly string _arguments;
        public string URL { get; }

        public URLArgumentExtractor(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL argument couldn't be Empty or Null.");
            }
            URL = url;

            int questionMarkIndex = url.IndexOf('?');
            _arguments = url.Substring(questionMarkIndex + 1);
        }

        public string GetArgumentValue(string parameterName)
        {
            string term = parameterName + "=";
            int termIndex = _arguments.IndexOf(term);
            string value = _arguments.Substring(termIndex + term.Length);
            int ampersand = value.IndexOf('&');
            if (ampersand == -1)
            {
                return value;
            }
            return value.Remove(ampersand);
        }
    }
}
