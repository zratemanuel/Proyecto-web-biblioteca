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

        public ActionResult UpdateAuthor()
        {
            return View();
        }

        public ActionResult ReadAuthor()
        {
            return View();
        }

        public ActionResult DeleteAuthor()
        {
            return View();
        }
    }
}
