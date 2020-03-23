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
            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
            {
                lst = (from d in db.T_TIPO
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
            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
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

        [HttpPost]
        public ActionResult Save(CreateBookViewModel model)
        {
            try
            {
                using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
                {
                    var oBook = new Models.T_LIBRO();
                    oBook.titulo = model.Titulo;
                    oBook.tipo = model.Tipo;
                    oBook.editorial = model.Editorial;
                    oBook.año = model.Anio;
                    oBook.autor = model.Autor;
                    db.T_LIBRO.Add(oBook);
                    db.SaveChanges();
                    
                }
                return Redirect("CreateBook/"); 
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

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
