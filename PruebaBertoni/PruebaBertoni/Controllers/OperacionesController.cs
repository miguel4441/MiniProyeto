using Dominio.Core.Entities;
using Dominio.Core.MainModule;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace PruebaBertoni.Controllers
{
    public class OperacionesController : Controller
    {
        AlbumManager albumManager = new AlbumManager();
        FotoManager fotoManager = new FotoManager();
        ComentariosManager comentariosManager = new ComentariosManager();
       
        public async Task<ActionResult> Album() {

            var list = await albumManager.listAlbum();

            return View(list);


        }

        public async Task<ActionResult> Fotos(int id_album)
        {

            var list = await fotoManager.listFoto(id_album);

            return View(list);


        }

        public async Task<ActionResult> Comentarios(int id_foto)
        {

            var list = await comentariosManager.listComentarios(id_foto);

            return Json(list, JsonRequestBehavior.AllowGet);


        }

    }
}