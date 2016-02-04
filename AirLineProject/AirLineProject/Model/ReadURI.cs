using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject.Model
{
    public class ReadURI
    {
        public Uri ReadFromURI(string URILocation, UriKind uriKind) 
        {
            Uri resourceUri = new Uri(URILocation, uriKind);
            return resourceUri;
        }
    }
}
