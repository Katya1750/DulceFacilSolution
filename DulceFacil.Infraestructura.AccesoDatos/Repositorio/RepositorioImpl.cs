using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{

    //CONSTRUCTOR LO QUE SE MAPEA EN LA BASE DE DATOS 
    public class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly DulceFacilDBContext _dBContext;
        private readonly DbSet<T> _dbSet;
        
       

        public RepositorioImpl(DulceFacilDBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = dBContext.dbSet<T>();
        }

        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex) 
            {
                throw new Exception("Error: No se pudo insertar datos, " + ex.Message);
            
            }   
        }
        //ELIMINAR
        public async Task DeleteAsync(int ID)
        {
            try
            {
                var entidad = await GetByIdAsync(ID); //Eliminar todas las tablas
                 _dbSet.Remove(entidad);
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo elminar datos, " + ex.Message);

            }
        }

        //LISTAR TODAS LAS TABLAS
        public Task DeleteAsync(T entidad)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync(); //Select * from
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo listar datos, " + ex.Message);

            }
        }
        //OBTENER POR EL ID
        public async Task<T> GetByIdAsync(int ID)
        {
            try
            {
                return await _dbSet.FindAsync(ID); //Buscar todas las tablas por ID, siempre y cuando sean números
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo elminar datos, " + ex.Message);
            }
            }
        //ACTUALIZAR
        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad); //Actualizar todas las tablas
                await _dBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo actualizar datos, " + ex.Message);

            }
        }
    }
}
