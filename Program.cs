using RestSharp;
using System;

namespace RESTAssetUploadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://your.cms.com/api/assets/upload");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer YourBearerToken");
            request.AddParameter("parentfolder", "af/105");
            request.AddParameter("updateonconflicts", "true");
            request.AddParameter("schemadefault", "false");
            request.AddParameter("overrideschemaid", "AssetSchemas/1");
            request.AddFile("file", @"C:\Path\to\your\file\test.dita");
            request.AddParameter("assetname", "test");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
