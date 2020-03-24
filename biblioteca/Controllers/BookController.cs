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
            Models.Common items = new Models.Common();

            ViewBag.items = items.ComboTipoLibro();
            ViewBag.itemsAutores = items.ComboAutores();

            return View();
        }

        [HttpPost]
        public ActionResult Save(BookViewModel model)
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

        // mZarate : Retorna vista con listado de libros con acción de Baja o Modificación
        public ActionResult UpdateBook()
        {
            Models.Common lst = new Models.Common();
            return View(lst.ListarLibros());
        }

        // mZarate : Update 1 - Envia conjunto de datos y actualiza en base de datos. Es invocado cuando su parámetro es un modelo
        [HttpPost]
        public ActionResult Update(BookViewModel model)
        {
            try
            {
                using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
                {
                    var oBook = db.T_LIBRO.Find(model.Id);
                    oBook.titulo = model.Titulo;
                    oBook.editorial = model.Editorial;
                    oBook.año = model.Anio;
                    oBook.autor = model.Autor;
                    oBook.tipo = model.Tipo;
                    db.Entry(oBook).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                return Redirect("~/Book/UpdateBook/");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }


        // mZarate : Update 2 - Envia conjunto de datos al modelo del formulario. Es invocado cuando su parámetro es un id integer
        public ActionResult Update(int Id)
        {
            Models.Common items = new Models.Common();

            ViewBag.items = items.ComboTipoLibro() ;
            ViewBag.itemsAutores = items.ComboAutores();

            BookViewModel model = new BookViewModel();

            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
            {
                var oBook = db.T_LIBRO.Find(Id);
                model.Titulo = oBook.titulo ;
                model.Editorial = oBook.editorial;
                model.Anio = oBook.año;
                model.Autor = oBook.autor;
                model.Tipo = oBook.tipo;
                return View(model);
            }
        }
    }
}
