﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class ComentarioDTO
    {
        public int IdComentario { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public bool Aprovado { get; set; }
    }
}
