﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Libreria
{
    public class Library : Conexion
    {
        public UploadImage uploadImage = new UploadImage();
        public TextBoxEvent txtEvent = new TextBoxEvent();
        //public Paginador<Estudiante> Paginador = new Paginador<Estudiante>();
    }
}
