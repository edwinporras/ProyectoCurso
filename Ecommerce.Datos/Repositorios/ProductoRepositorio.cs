using Ecommerce.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos.Repositorios
{
    public class ProductoRepositorio
    {
        private TiendaLibreConection BD;

        public ProductoRepositorio()
        {
            BD = new TiendaLibreConection();
        }
        /// <summary>
        /// Permite Consultar los productos disponibles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Producto> ObtenerProductos()
        {
            return BD.Producto;
        }
        
    }
}
