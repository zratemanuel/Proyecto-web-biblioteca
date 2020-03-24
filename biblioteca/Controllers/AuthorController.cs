using biblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biblioteca.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult CreateAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(AutoresViewModel model)
        {
            try
            {
                using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
                {
                    var oAutor = new Models.T_AUTOR();
                    oAutor.nombre = model.Nombre;
                    oAutor.nacionalidad= model.Nacionalidad;
                    oAutor.fechaNacimiento = model.FechaNacimiento;
                    oAutor.descripcion = model.Descripcion;
                    db.T_AUTOR.Add(oAutor);
                    db.SaveChanges();

                }
                return Redirect("CreateAuthor/");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

        }

        // mZarate : Retorna vista con listado de autores con acción de Baja o Modificación
        public ActionResult UpdateAuthor()
        {
            Models.Common lst = new Models.Common();
            return View(lst.ListarAutores());
        }

        // mZarate : Update 1 - Envia conjunto de datos y actualiza en base de datos. Es invocado cuando su parámetro es un modelo
        [HttpPost]
        public ActionResult Update(AutoresViewModel model)
        {
            try
            {
                using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
                {
                    var oAutor = db.T_AUTOR.Find(model.Id);
                    oAutor.nombre = model.Nombre;
                    oAutor.nacionalidad = model.Nacionalidad;
                    oAutor.fechaNacimiento = model.FechaNacimiento;
                    oAutor.descripcion = model.Descripcion;
                    db.Entry(oAutor).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                return Redirect("~/Author/UpdateAuthor/");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // mZarate : Update 2 - Envia conjunto de datos al modelo del formulario. Es invocado cuando su parámetro es un id integer
        public ActionResult Update(int Id)
        {
            AutoresViewModel model = new AutoresViewModel();

            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
            {
                var oAutor = db.T_AUTOR.Find(Id);
                model.Nombre = oAutor.nombre;
                model.Nacionalidad = oAutor.nacionalidad;
                model.FechaNacimiento = oAutor.fechaNacimiento;
                model.Descripcion = oAutor.descripcion;
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
            {
                var oAutor = db.T_AUTOR.Find(Id);
                db.T_AUTOR.Remove(oAutor);
                db.SaveChanges();
            }
            return Redirect("~/Author/UpdateAuthor/");
        }

        public ActionResult ReadAuthor()
        {
            Models.Common lst = new Models.Common();
            return View(lst.ListarAutores());
        }
    }
}
