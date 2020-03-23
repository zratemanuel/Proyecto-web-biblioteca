using biblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biblioteca.Controllers
{
    public class BookController : Controller
    {
        public ActionResult CreateBook()
        {
            List<TipoViewModels> lst = null;
            using (Models.bibliotecadbEntitiesModel db = new Models.bibliotecadbEntitiesModel())
            {
                lst = ( from d in db.T_TIPO
                      select new TipoViewModels
                      {
                        Id = d.idTipo,
                        Nombre = d.nombre
                      }).ToList();
            }

            List<SelectListItem> items = lst.ConvertAll(d =>
           {
               return new SelectListItem()
               {
                   Text = d.Nombre.ToString(),
                   Value = d.Id.ToString(),
                   Selected = false
               };

           }
           );

            ViewBag.items = items;

            List<AutoresViewModel> lstAutores = null;
            using (Models.bibliotecadbEntitiesModel db = new Models.bibliotecadbEntitiesModel())
            {
                lstAutores = (from d in db.T_AUTOR
                       select new AutoresViewModel
                       {
                           Id = d.idAutor,
                           Nombre = d.nombre
                       }).ToList();
            }

            List<SelectListItem> itemsAutores = lstAutores.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };

            }
           );

            ViewBag.items = items;
            ViewBag.itemsAutores = itemsAutores;

            return View();
        }

        public ActionResult UpdateBook()
        {
            return View();
        }

        public ActionResult ReadBook()
        {
            return View();
        }

        public ActionResult DeleteBook()
        {
            return View();
        }

    }
}
