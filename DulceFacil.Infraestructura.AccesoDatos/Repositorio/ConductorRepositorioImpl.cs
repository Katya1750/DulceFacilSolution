using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class ConductorRepositorioImpl : RepositorioImpl<Conductor>, IConductorRepositorio
    {
        public ConductorRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {

        }
    }
}
