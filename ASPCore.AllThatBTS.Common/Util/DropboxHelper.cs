using Dropbox.Api;
using Dropbox.Api.Files;
using Dropbox.Api.Sharing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ASPCore.AllThatBTS.Common.Util
{
    public class DropboxHelper
    {
        public object UploadTest()
        {
            
            DropboxClient client = new DropboxClient("5JDFm84qP34AAAAAAACSSfukaAZGwHMvDmBlK7sTQoiXQhPmsI-n-Wo3C32ZDvZX");
            ListFolderResult result = client.Files.ListFolderAsync("/2019-01-01").Result;

            Console.WriteLine("Upload file...");

            string fileName = @"D:\Download\25037067_387924058312063_1408701744979902464_n.jpg";

            using (var stream = new MemoryStream(File.ReadAllBytes(fileName)))
            {
                var response = client.Files.UploadAsync(@"/" + System.DateTime.Today.ToShortDateString() + 
                    "/" + DateTime.Today.Ticks.ToString(), WriteMode.Overwrite.Instance, body: stream).Result;

                Console.WriteLine("Uploaded;");
            }

            return result;
        }

        public object DownloadTest()
        {

            DropboxClient client = new DropboxClient("5JDFm84qP34AAAAAAACSSfukaAZGwHMvDmBlK7sTQoiXQhPmsI-n-Wo3C32ZDvZX");
            ListFolderResult result = client.Files.ListFolderAsync("/2019-01-01").Result;

            Console.WriteLine("Download file...");


            CreateSharedLinkWithSettingsArg createSharedLinkWithSettingsArg = new CreateSharedLinkWithSettingsArg(@"/2019-01-06/test.png",
                new SharedLinkSettings(new RequestedVisibility().AsPublic, null, DateTime.MaxValue));

            //var pathLinkResult = client.Sharing.CreateSharedLinkWithSettingsAsync(createSharedLinkWithSettingsArg).Result;

            //string url = pathLinkResult.Url;

            //string url2 = client.Sharing.GetSharedLinkFileAsync(url).Result.Response.Url;




            return result;
        }

    }
}
