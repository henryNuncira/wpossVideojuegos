using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWpossVideojuegos.Dto;
using WebApiWpossVideojuegos.Models;

namespace WebApiWpossVideojuegos.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {
        VideojuegoPWPossVs2Context context = new VideojuegoPWPossVs2Context();

        //----------------************* CRUD de Clientes *******-----------------

        //listar Todos los campos del cliente que existen
        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {

            return context.Clientes.ToList();

        }

        //   listar un cliente a travez de un id
        [HttpGet("{idCliente}")]
        public Cliente GetListarclienteId(int idCliente)
        {
            var rescliente = context.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);
            return rescliente;

        }


        //listar Todos los clientes que tiene alquilado un juego y poder reclamarlo cuando se venza el periodo de alquiler
        //[httpget("{idcliente}")]
        //public actionresult getclientejuegoalquilado(int idcliente)
        //{
        //    var cliente = context.clientes.tolist();
        //    var venta = context.ventaalquilers.tolist();

        //    var clienteventa = context.clientes.where(x = cliente);

        //    return venta;

        //}

        // agregar un nuevo cliente
        [HttpPost]
        public Response PostNuevoBodyCliente(BodyCliente bodycliente)
        {
            try
            {
                // CCCContext context = new CCCContext();
                Cliente clien = new Cliente
                {
                    Nit = bodycliente.Nit,
                    Nombre = bodycliente.Nombre,
                    Apellidos = bodycliente.Apellidos,
                    Direccion = bodycliente.Direccion,
                    Correo = bodycliente.Correo,
                    Edad = bodycliente.Edad,
                    Telefono = bodycliente.Telefono,
                    
                   
                };
                context.Clientes.Add(clien);
                context.SaveChanges();
                return new Response { state = 200, message = "Se creo un nuevo cliente correctamente" };
            }
            catch (Exception ex)
            {
                throw new ApplicationException(Convert.ToString(ex));
            }

        }


        // actualizar o modificar uno existente
        [HttpPut("{idCliente}")]
        public ActionResult PutCliente(int idCliente, Cliente cliente)
        {


            if (cliente.IdCliente == idCliente)
            {
                context.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        //  eliminar
        [HttpDelete("{idCliente}")]
        public ActionResult DeleteCliente(int idCliente)
        {
            // var cliente = context.Clientes.Find(idCliente);
            var cliente = context.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);

            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        //----------------************* CRUD de Videojuegos *******------------------

        //listar Todos los campos que existen
        [HttpGet]
        public IEnumerable<VideoJuego> GetVideojuegos()
        {

            return context.VideoJuegos.ToList();

        }

        // agregar un nuevo cliente
        [HttpPost]
        public Response PostNuevoBodyVideojuego(BodyVideojuego bodyvideojuego)
        {
            try
            {
                // CCCContext context = new CCCContext();
                VideoJuego Videogame = new VideoJuego
                {
                    Nombre = bodyvideojuego.Nombre,
                    Titulo = bodyvideojuego.Titulo,
                    Año = bodyvideojuego.Año,
                    Protagonista = bodyvideojuego.Protagonista,
                    Director = bodyvideojuego.Director,
                    Productor = bodyvideojuego.Productor,
                    Tecnologia = bodyvideojuego.Tecnologia,
                    Precio = bodyvideojuego.Precio,
                    Stock = bodyvideojuego.Stock,
                    Imagen = bodyvideojuego.Imagen,


                };
                context.VideoJuegos.Add(Videogame);
                context.SaveChanges();
                return new Response { state = 200, message = "Se creo un nuevo cliente correctamente" };
            }
            catch (Exception ex)
            {
                throw new ApplicationException(Convert.ToString(ex));
            }

        }


        // actualizar o modificar uno existente
        [HttpPut("{idVideoJuego}")]
        public ActionResult PutVideojuego(int idVideoJuego, VideoJuego videojuego)
        {


            if (videojuego.IdVideoJuego == idVideoJuego)
            {
                context.Entry(videojuego).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        //  eliminar
        [HttpDelete("{idVideoJuego}")]
        public ActionResult DeleteVideo(int idVideoJuego)
        {
            // var cliente = context.Clientes.Find(idCliente);
            var videogame = context.VideoJuegos.FirstOrDefault(x => x.IdVideoJuego == idVideoJuego);

            if (videogame != null)
            {
                context.VideoJuegos.Remove(videogame);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        //----------------************* CRUD de Venta y alquiler *******------------------

        //listar Todos los campos  que existen
        [HttpGet]
        public IEnumerable<VentaAlquiler> GetVentaAlquiler()
        {

            return context.VentaAlquilers.ToList();

        }


        // agregar un nuevo 
        [HttpPost]
        public Response PostNuevoBodyVentaAlquiler(BodyVenta bodyVenta)
        {
            try
            {
                // CCCContext context = new CCCContext();
                VentaAlquiler vende = new VentaAlquiler
                {
                    TipoComprobante = bodyVenta.TipoComprobante,
                    SerieComprobante = bodyVenta.SerieComprobante,
                    NumComprobante = bodyVenta.NumComprobante,
                    FechaInicio = DateTime.Now,
                    FechaEntrega = bodyVenta.FechaEntrega,
                    Impuesto = bodyVenta.Impuesto,
                    Total = bodyVenta.Total,
                    Estado = bodyVenta.Estado,


                };
                context.VentaAlquilers.Add(vende);
                context.SaveChanges();
                return new Response { state = 200, message = "Se creo un nuevo cliente correctamente" };
            }
            catch (Exception ex)
            {
                throw new ApplicationException(Convert.ToString(ex));
            }

        }


        // actualizar o modificar uno existente
        [HttpPut("{idVenta}")]
        public ActionResult PutVenta(int idVenta, VentaAlquiler venta)
        {


            if (venta.IdVenta == idVenta)
            {
                context.Entry(venta).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        //  eliminar
        [HttpDelete("{idVenta}")]
        public ActionResult DeleteVenta(int idVenta)
        {
            var venta = context.VentaAlquilers.FirstOrDefault(x => x.IdVenta == idVenta);

            if (venta != null)
            {
                context.VentaAlquilers.Remove(venta);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
        //----------------************* CRUD de DetalleVEnta *******------------------

        //listar Todos los campos de los detalles de venta que existen
        [HttpGet]
        public IEnumerable<DetalleVentum> GetDetalleVenta()
        {

            return context.DetalleVenta.ToList();

        }

        //   listar un cliente a travez de un id
        [HttpGet("{idDetalle}")]
        public DetalleVentum GetListardetalleVetaId(int idDetalle)
        {
            var resVenta = context.DetalleVenta.FirstOrDefault(x => x.IdDetalle == idDetalle);
            return resVenta;

        }
        //   listar la venta del dia
        [HttpGet]
        public IEnumerable<DetalleVentum> GetListarVentaDia()
        {
            var resVEntaHOy = context.DetalleVenta.Where(x => x.FechaVenta == DateTime.Today).ToList();
            return resVEntaHOy;

        }
        // agregar un nuevo detalle venta
        [HttpPost]
        public Response PostNuevoBodyDetalle(BodyDetalle bodyDetalle)
        {
            try
            {
                // CCCContext context = new CCCContext();
                DetalleVentum detalleVenAlquiler = new DetalleVentum
                {
                    FechaVenta = DateTime.Now,
                    TipoVenta = bodyDetalle.TipoVenta,
                    Cantidad = bodyDetalle.Cantidad,
                    Precio = bodyDetalle.Precio,
                    Descuento = bodyDetalle.Descuento,
                    IdVideoGame = bodyDetalle.IdVideoGame,
                   


                };
                context.DetalleVenta.Add(detalleVenAlquiler);
                context.SaveChanges();
                return new Response { state = 200, message = "Se creo un nuevo cliente correctamente" };
            }
            catch (Exception ex)
            {
                throw new ApplicationException(Convert.ToString(ex));
            }

        }


        // actualizar o modificar uno existente
        [HttpPut("{idDetalle}")]
        public ActionResult PutDetalleVenta(int idDetalle, DetalleVentum Detalle)
        {


            if (Detalle.IdDetalle == idDetalle)
            {
                context.Entry(Detalle).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        //  eliminar
        [HttpDelete("{idDetalle}")]
        public ActionResult DeleteDetalle(int idDetalle)
        {
            // var cliente = context.Clientes.Find(idCliente);
            var detalle = context.DetalleVenta.FirstOrDefault(x => x.IdDetalle == idDetalle);

            if (detalle != null)
            {
                context.DetalleVenta.Remove(detalle);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
