using Ecommerce.Datos.Repositorios;
using Ecommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ecommerce.Datos.Extensiones;
using Ecommerce.Datos.Modelo;

namespace Ecommerce.Servicios.Controllers
{
    public class ProductoController : ApiController
    {
        private ProductoRepositorio repositorio;
        TiendaLibreConection BDS = new TiendaLibreConection();

        public ProductoController()
        {
            repositorio = new ProductoRepositorio();
        }
        [HttpGet]
        public IEnumerable<ProductoDTO> ObtenerProductos()
        {

            var listado = repositorio.ObtenerProductos();
            
            return listado.Select(x=>x.ToDTO());
        }

        [HttpGet]
        public ProductoDTO Get(int id)
        {

            var listado = BDS.Producto.FirstOrDefault(x => x.IdProducto == id);

            return listado.ToDTO();
        }
        [HttpPost]
        public  bool Post(Producto prodto)
        {
            
            BDS.Producto.Add(prodto);
            return BDS.SaveChanges() >0;
        }

        [HttpPut]
        public bool Put(Producto prodto)
        {
            var actualizarD = BDS.Producto.FirstOrDefault(x => x.IdProducto==prodto.IdProducto);
            actualizarD.Nombre = prodto.Nombre;
            actualizarD.Precio = prodto.Precio;
            actualizarD.Stock = prodto.Stock;
            actualizarD.Descripcion = prodto.Descripcion;
            actualizarD.Referencia = prodto.Referencia;
            actualizarD.ImagenProducto = prodto.ImagenProducto;
            BDS.Producto.Add(prodto);
            return BDS.SaveChanges() > 0;
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            var eliminarD = BDS.Producto.FirstOrDefault(x => x.IdProducto == id);
            BDS.Producto.Remove(eliminarD);
            return BDS.SaveChanges() > 0;
        }


    }
}
