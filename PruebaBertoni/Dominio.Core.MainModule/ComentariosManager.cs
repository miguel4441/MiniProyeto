using Dominio.Core.Entities;
using Infraestructura.Data.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.MainModule
{
   public  class ComentariosManager
    {
        ComentariosDAL comentariosDAL = new ComentariosDAL();
        public async Task<List<Comentarios>> listComentarios(int id_foto)
        {

            return await comentariosDAL.listComentarios(id_foto);

        }

    }
}
