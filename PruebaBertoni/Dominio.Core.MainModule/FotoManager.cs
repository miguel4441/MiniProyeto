using Dominio.Core.Entities;
using Infraestructura.Data.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Core.MainModule
{
   public  class FotoManager
    {
        FotoDAL fotoDAL = new FotoDAL();
        public async Task<List<Foto>> listFoto(int id_album)
        {

            return await fotoDAL.listFoto(id_album);

        }

    }
}
