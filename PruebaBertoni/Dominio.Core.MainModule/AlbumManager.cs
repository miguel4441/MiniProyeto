using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entities;
using Infraestructura.Data.Api;

namespace Dominio.Core.MainModule
{
    public class AlbumManager
    {

        AlbumDAL albumDAL = new AlbumDAL();

        public async Task<List<Album>> listAlbum()
        {

            return await albumDAL.listAlbum();

        }

    }
}