using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //Indexer gets or sets the value of the dictionary object based on the key
        public string this[string key]
        {
            get { return _dictionary[key];}
            set { _dictionary[key] = value;}
        }
    }
}
