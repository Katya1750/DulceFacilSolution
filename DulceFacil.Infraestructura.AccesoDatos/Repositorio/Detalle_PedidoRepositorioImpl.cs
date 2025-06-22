using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class Detalle_PedidoRepositorioImpl : RepositorioImpl<Detalle_Pedido>, IDetalle_PedidoRepositorio
    {
        public Detalle_PedidoRepositorioImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }
}
