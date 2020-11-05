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
  public   class ComentariosDAL
    {


        public async Task<List<Comentarios>> listComentarios(int id_foto)
        {

            List<Comentarios> list = new List<Comentarios>();

            string respuesta = string.Empty;
            using (var client = new HttpClient())
            {

                HttpResponseMessage resultado = await client.GetAsync("https://jsonplaceholder.typicode.com/comments");

                if (resultado.IsSuccessStatusCode)
                {
                    respuesta = await resultado.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Comentarios>>(respuesta).ToList();

                }

            }

            return list.Where(p => p.id == id_foto).ToList();

        }

    }
}
