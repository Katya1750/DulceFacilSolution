using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public class Bitacora_EventosImpl : RepositorioImpl<Bitacora_Eventos>, IBitacora_EventosRepositorio
    {
        public Bitacora_EventosImpl(DulceFacilDBContext dBContext) : base(dBContext)
        {
        }
    }

    
    }

