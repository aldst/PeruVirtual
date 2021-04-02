using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Servicios
{
    public class Facebooklogin
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<VO.Code> getCode()
        {
            var values = new Dictionary<string, string>
            {
                { "access_token", "326527821977671|2b594617951c9b59727c2bd57735280c"},
                {"scope", "public_profile, email"}
            };

            var content = new FormUrlEncodedContent(values);

            var response =await client.PostAsync("https://graph.facebook.com/v2.6/device/login", content).ConfigureAwait(false);

            var responseString =await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            //Console.WriteLine(responseString);

            VO.Code code = (JsonConvert.DeserializeObject<VO.Code>(responseString));

            return code;
        }

        public async Task<VO.Autho> getAuth(string code)
        {
            var values = new Dictionary<string, string>
            {
                { "access_token", "326527821977671|2b594617951c9b59727c2bd57735280c"},
                {"code", code }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://graph.facebook.com/v2.6/device/login_status",content).ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            VO.Autho autho = JsonConvert.DeserializeObject<VO.Autho>(responseString);
            
            return autho;

        }

        public async Task<VO.FacebookUser> getUser(string user_access)
        {
            var response = await client.GetAsync("https://graph.facebook.com/v2.3/me?fields=name,email&access_token=" + user_access).ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            VO.FacebookUser facebookUser = JsonConvert.DeserializeObject<VO.FacebookUser>(responseString);
            return facebookUser;
        }
    }
}
