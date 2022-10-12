# CSRequests
C# Secured Requests (Wouldn't Recommended)

# Code
```c#
namespace SecurityRequests
{
    public class Req
    {
        public static string SendGet(string Url)
        {
            var Response = "";
            try
            {
            // These are Fake Strings (When someone Dumps Strings he should see these just to confuse Reversers)
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
```

# Usage (If you want Compile it Self)
 - Install Leaf.xNet
