using Erp_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Erp_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Shampoo", Precio = 10.5m, Stock = 50 },
            new Producto { Id = 2, Nombre = "Acondicionador", Precio = 12.0m, Stock = 30 }
        };

        // GET: api/productos
        [HttpGet("GetRows")]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            return productos;
        }

        // GET: api/productos/1
        [HttpGet("GetByID{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null) return NotFound();
            return producto;
        }

        // POST: api/productos
        //Metodo Create (Agrega nuevo producto a la lista)
        [HttpPost("Create")]
        public ActionResult<Producto> PostProducto(Producto producto)
        {
            producto.Id = productos.Count > 0 ? productos.Max(p => p.Id) + 1 : 1;
            productos.Add(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }

        // PUT: api/productos/1
        //Metodo Update (Actualiza prodcuto existente en la lista)
        [HttpPut("Update/{id}")]
        public ActionResult<Producto> PutProducto(int id, Producto producto)
        {
            var productExist = productos.FirstOrDefault(p => p.Id == id);
            if (productExist == null) return NotFound();

            productExist.Nombre = producto.Nombre;
            productExist.Precio = producto.Precio;
            productExist.Stock = producto.Stock;

            return productExist;
        }

        // DELETE: api/productos/1
        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null) return NotFound();

            productos.Remove(producto);
            return NoContent();
        }
    }
}
