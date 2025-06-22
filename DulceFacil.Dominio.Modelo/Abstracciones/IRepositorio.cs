using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Creamos Interfaz de Repositorio

namespace DulceFacil.Dominio.Modelo.Abstracciones
{
   public interface IRepositorio<T> where T : class //1. Cambiamos a public
    {
        Task AddAsync(T entidad); //Insertar
        Task UpdateAsync(T entidad); //Actualizar
        Task DeleteAsync(T entidad); //Eliminar
        Task<IEnumerable<T>> GetAllAsync(); //Listar select * from
        Task<T> GetByIdAsync(int id); //Buscar por id
    }
}
