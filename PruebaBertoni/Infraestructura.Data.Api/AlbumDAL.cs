using Dominio.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Data.Api
{
   public  class AlbumDAL
    {

        public async Task<List<Album>> listAlbum() {

            List<Album> list = new List<Album>();

            string respuesta = string.Empty;
            using (var client = new HttpClient())
            {

                HttpResponseMessage resultado = await client.GetAsync("https://jsonplaceholder.typicode.com/albums");

                if (resultado.IsSuccessStatusCode)
                {
                    respuesta = await resultado.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Album>>(respuesta).ToList();

                }

            }

            return list;

        }




    }
}
