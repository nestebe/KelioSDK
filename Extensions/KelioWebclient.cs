using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KelioSDK.Extensions
{
    public class KelioWebclient : WebClient
    {
        public int Timeout { get; set; }

        public KelioWebclient(string username, string password, string action, int timeoutSeconds = 60)  
        {
            try
            {
                this.Timeout = timeoutSeconds * 1000;
                this.Encoding = Encoding.UTF8;
                this.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";
                this.Headers[HttpRequestHeader.ContentType] = "text/xml; charset=utf-8";
                this.Headers[HttpRequestHeader.Accept] = "text/xml";
                this.Headers.Add("SOAPAction", "\"urn:" + action + "\"");
                this.Headers[HttpRequestHeader.Authorization] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
            }
            catch
            {

            }
    
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            ServicePointManager.FindServicePoint(address).Expect100Continue = false;
            HttpWebRequest webRequest = base.GetWebRequest(address) as HttpWebRequest;
            webRequest.Timeout = this.Timeout;
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return (WebRequest)webRequest;
        }
    }
}
