using AppDistribuidas6488.Models;
using AppDistribuidas6488.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AppDistribuidas6488.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LigasController : ControllerBase
    {
        RepositoryLigas repo;
        public LigasController(RepositoryLigas repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Ligas>> GetLigas()
        {
            return this.repo.GetLigas();
        }
        [HttpGet("{id}")]
        public ActionResult<Ligas> BuscarLiga(int id)
        {
            return this.repo.GetLigaId(id);
        }
        [HttpGet]
        [Route("[action]/{Nombre}")]
        public ActionResult<List<Ligas>> BuscarLigasNombre(String Nombre)
        {
            return this.repo.GetLigasNombre(Nombre);
        }
        [HttpPost]
        public void NuevaLiga(Ligas lig)
        {
            this.repo.NuevaLiga(lig.Nombre, lig.Descripcion);
        }
        [HttpPut]
        public void ModificarLiga(Ligas lig)
        {
            this.repo.ModificarLiga(lig.IdLiga, lig.Nombre, lig.Descripcion);
        }
        [HttpDelete("{id}")]
        public void EliminarLiga(int id)
        {
            this.repo.EliminarLiga(id);
        }

    }
}
