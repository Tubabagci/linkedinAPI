using System;

namespace linkedinAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            // Get the ClientID and ClientSecret to get the access token
            string client_id = "*********Y77x1u7cb9kasbq";
            string client_secret = "*******sPZtqbEfdsSlH0AX";
            string organization_id = "********2928372";

            string base_url = "https://www.linkedin.com/developers/apps/verification/3fd3b801-ea36-4483-ae83-734d8093e6c7";
            string redirect_uri = "https://www.nuevo.com.tr/auth/linkedin/callback";
            //scope = "w_member_social,r_liteprofile"

            string url = "f" + base_url + "?response_type=code&client_id=" + client_id + "&state=random&redirect_uri=" + redirect_uri + "&scope={scope}";
            Console.WriteLine(url);
        }
    }
}
