using biblioteca.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biblioteca.Models
{
    public class Common
    {
        public List<SelectListItem> ComboAutores()
        {
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

            List<SelectListItem> itemsAutores = lstAutores.ConvertAll(d => {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };

            });
            return itemsAutores;
        }

        public List<SelectListItem> ComboTipoLibro()
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

            List<SelectListItem> items = lst.ConvertAll(d => {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),
                    Selected = false
                };

            });
            return items;
        }

        public List<ListBooksViewModel> ListarLibros()
        {
            List<ListBooksViewModel> lst = null;
            using (Models.bibliotecadbEntities db = new Models.bibliotecadbEntities())
            {
                lst = (from d in db.T_LIBRO
                       join au in db.T_AUTOR on d.autor equals au.idAutor
                       join tp in db.T_TIPO on d.tipo equals tp.idTipo
                       select new ListBooksViewModel
                       {
                           Id = d.id_libro,
                           Titulo = d.titulo,
                           Editorial = d.editorial,
                           Anio = d.año,
                           Tipo = tp.nombre,
                           Autor = au.nombre
                       }).ToList();
            }
            return lst;
        }
    }
}