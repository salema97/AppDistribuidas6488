
using AppDistribuidas6488.Data;
using AppDistribuidas6488.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppDistribuidas6488.Repositories
{
    public class RepositoryLigas
    {
        LigasContext context;
        public RepositoryLigas(LigasContext context)
        {
            this.context = context;
        }
        public List<Ligas> GetLigas()
        {
            return this.context.Ligas.ToList();
        }
        public Ligas GetLigaId(int id)
        {
            return this.context.Ligas.Where(x => x.IdLiga == id).FirstOrDefault();
        }
        public List<Ligas> GetLigasNombre(String nombre)
        {
            return this.context.Ligas.Where(x => x.Nombre.Contains(nombre)).ToList();
        }

        public int GetMaxIdLiga()
        {
            return this.context.Ligas.Max(x => x.IdLiga);
        }

        public void NuevaLiga(String nombre, String descripcion)
        {
            Ligas lig = new Ligas();
            lig.IdLiga = this.GetMaxIdLiga() + 1;
            lig.Nombre = nombre;
            lig.Descripcion = descripcion;
            this.context.Add(lig);
            this.context.SaveChanges();
        }
        public void ModificarLiga(int id, String nombre, String descripcion)
        {
            Ligas lig = this.GetLigaId(id);
            lig.Nombre = nombre;
            lig.Descripcion = descripcion;

            this.context.SaveChanges();
        }
        public void EliminarLiga(int id)
        {
            Ligas lig = this.GetLigaId(id);
            this.context.Ligas.Remove(lig);
            this.context.SaveChanges();
        }
    }
}
