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
using System.Web.Http.Cors;
using Proyecto_Peliculas.Service;
using Proyecto_Peliculas.Exceptions;

namespace Proyecto_Peliculas.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class PeliculasController : ApiController
    {
        private IPeliculasService peliculasService;

        public PeliculasController(IPeliculasService _peliculasService)
        {
            this.peliculasService = _peliculasService;
        }

        // GET: api/Peliculas
        public IQueryable<Peliculas> GetPeliculas()
        {
            return peliculasService.Get();
        }

        // GET: api/Peliculas/5
        [ResponseType(typeof(Peliculas))]
        public IHttpActionResult GetPelicula(long id)
        {
            Peliculas peliculas = peliculasService.Get(id);
            if (peliculas == null)
            {
                return NotFound();
            }

            return Ok(peliculas);
        }

        // PUT: api/Peliculas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPelicula(long id, Peliculas pelicula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pelicula.id)
            {
                return BadRequest();
            }

            try
            {
                peliculasService.Put(pelicula);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Peliculas
        [ResponseType(typeof(Peliculas))]
        public IHttpActionResult PostPeliculas(Peliculas pelicula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            pelicula = peliculasService.Create(pelicula);

            return CreatedAtRoute("DefaultApi", new { id = pelicula.id }, pelicula);
        }

        // DELETE: api/Peliculas/5
        [ResponseType(typeof(Peliculas))]
        public IHttpActionResult DeletePeliculas(long id)
        {
            Peliculas pelicula;
            try
            {
                pelicula = peliculasService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}