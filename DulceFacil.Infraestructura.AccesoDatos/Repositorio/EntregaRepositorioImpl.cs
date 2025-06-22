using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class EntregaRepositorioImpl : RepositorioImpl<Entrega>, IEntregaRepositorio
    {
        public EntregaRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
