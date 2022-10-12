using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecurityRequests
{
    public class Req
    {
        public static string SendGet(string Url)
        {
            var Response = "";
            try
            {
                string JunkStr = "https://auth.gg/newreq";
                string JunkStr2 = "https://keyauth.win/api";
                string JunkStr3 = "https://gtihub.com/" + Environment.UserName + "/Backend";

                var Request = new Leaf.xNet.HttpRequest();
                Request.SslCertificateValidatorCallback = (RemoteCertificateValidationCallback)Delegate.Combine(Request.SslCertificateValidatorCallback, new RemoteCertificateValidationCallback((object obj, X509Certificate cert, X509Chain ssl, SslPolicyErrors error) => (cert as X509Certificate2).Verify()));
                Response = Request.Get(Url).ToString();
            }
            catch { }

            return Response;
        }
    }
}