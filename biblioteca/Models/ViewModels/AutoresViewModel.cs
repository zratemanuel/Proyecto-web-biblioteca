﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace biblioteca.Models.ViewModels
{
    public class AutoresViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaNacimiento { get; set; }
        public string Descripcion { get; set; }

    }
}