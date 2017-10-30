using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inżynierka.Presenter
{
    class ApiPresenter
    {
        public List<Model.PostModel> Posts = new List<Model.PostModel>;
        private static string ApiPostsConnection = @"http://api.altar.darkville.o12.pl/api/posts";
        private static HttpClient client = new HttpClient();

        public async Task<List<Model.PostModel>> GetPosts()
        {
            var response = await client.GetAsync(ApiPostsConnection);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStreamAsync();
                Posts = JsonConvert.DeserializeObject<List<Model.PostModel>>(jsonString.ToString());
            }
        }
        
        //private static HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ApiPostsConnection);
        //private static HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //private static Stream stream = response.GetResponseStream();

        //private static Dictionary<string, Model.PostModel> GetAllPosts()
        //{
        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using
        //    }




        //}


    }
}
