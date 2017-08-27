using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Proyecto_Peliculas.Modelos;
using Proyecto_Peliculas.Models;
using Proyecto_Peliculas.Service;
using Proyecto_Peliculas.Exceptions;
using System.Web.Http.Cors;

namespace Proyecto_Peliculas.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class EntradasController : ApiController
    {
        private IEntradasService entradasService;

        public EntradasController(IEntradasService _entradasService)
        {
            this.entradasService = _entradasService;
        }

        // GET: api/Entradas
        public IQueryable<Entradas> GetEntradas()
        {
            return entradasService.Get();
        }

        // GET: api/Entradas/5
        [ResponseType(typeof(Entradas))]
        public IHttpActionResult GetEntrada(long id)
        {
            Entradas entradas = entradasService.Get(id);
            if (entradas == null)
            {
                return NotFound();
            }

            return Ok(entradas);
        }

        // PUT: api/Entradas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEntrada(long id, Entradas entrada)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entrada.id)
            {
                return BadRequest();
            }

            try
            {
                entradasService.Put(entrada);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Entradas
        [ResponseType(typeof(Entradas))]
        public IHttpActionResult PostEntrada(Entradas entrada)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entrada = entradasService.Create(entrada);

            return CreatedAtRoute("DefaultApi", new { id = entrada.id }, entrada);
        }

        // DELETE: api/Entradas/5
        [ResponseType(typeof(Entradas))]
        public IHttpActionResult DeleteEntrada(long id)
        {
            Entradas entrada;
            try
            {
                entrada = entradasService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(entrada);
        }
    }
}