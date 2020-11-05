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
    public class FotoDAL
    {

        public async Task<List<Foto>> listFoto(int id_album)
        {

            List<Foto> list = new List<Foto>();

            string respuesta = string.Empty;
            using (var client = new HttpClient())
            {

                HttpResponseMessage resultado = await client.GetAsync("https://jsonplaceholder.typicode.com/photos");

                if (resultado.IsSuccessStatusCode)
                {
                    respuesta = await resultado.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Foto>>(respuesta).ToList();

                }

            }

            return list.Where(p=>p.albumId== id_album).ToList();

        }

    }
}
