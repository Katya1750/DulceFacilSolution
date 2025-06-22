using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    internal class VehiculoRepositorioImpl : RepositorioImpl<Vehiculo>, IVehiculoRepositorio
    {
        public VehiculoRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
