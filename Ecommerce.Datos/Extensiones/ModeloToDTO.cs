using Ecommerce.Datos.Modelo;
using Ecommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos.Extensiones
{
    public static class ModeloToDTO
    {
        public static ProductoDTO ToDTO(this Producto model)
        {
            return new ProductoDTO
            {
                IdProducto = model.IdProducto,
                Descripcion = model.Descripcion,
                Nombre = model.Nombre,
                Precio = model.Precio,
                Referencia = model.Referencia,
                Stock = model.Stock,
                Imagenes = model.ImagenProducto.Select(x=> x.ToDTO())
            };
        }

        public static ImagenProductoDTO ToDTO(this ImagenProducto model)
        {
            return new ImagenProductoDTO
            {
               IdImagenProducto = model.IdImagenProducto,
               EsPortada = model.EsPortada,
               IdProducto = model.IdProducto,
               Url = model.Url
            };
        }
    }
}
