using Album.Models;
using Newtonsoft.Json;
using Processor.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Process.Repository
{
    public class ProcessorAlbum : IProcessorAlbum

    {

        public async Task<List<AlbumTitleVM>> LoadInfo(string search)
        {
            // pulling dummy data from URL.               
            using (var client = new HttpClient())
            {
                // Rest Client info

                client.DefaultRequestHeaders.Accept.Clear();
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/ ");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("albums");

                if (Res.IsSuccessStatusCode)
                {
                    var AlbumResp = Res.Content.ReadAsStringAsync().Result;
                    var AlbumTitle = JsonConvert.DeserializeObject<List<AlbumTitleVM>>(AlbumResp);

                    //making search result case-insensitive and saving
                    if (search != "")
                        return AlbumTitle.Where(album => album.Title.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
                    return AlbumTitle;
                }
                else
                {
                    throw new Exception("Please try again later");
                }


            }
        }
    }
}
