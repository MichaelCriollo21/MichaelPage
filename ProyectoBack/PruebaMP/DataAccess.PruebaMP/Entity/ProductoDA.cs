using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.PruebaMP.Entity
{
    public class ProductoDA : IBase<Producto>
    {
        private readonly SqlConnection _conexion;
        private readonly SqlTransaction _transaccion;

        public ProductoDA(SqlConnection conexion, SqlTransaction transaccion)
        {
            _conexion = conexion;
            _transaccion = transaccion;
        }

        public void Create(Producto entity)
        {
            using var comando = new SqlCommand("sp_createProductos", _conexion, _transaccion)
            {
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@NombreProducto", entity.NombreProducto);
            comando.Parameters.AddWithValue("@ImagenProducto", entity.ImagenProducto);
            comando.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);
            comando.Parameters.AddWithValue("@Ext", entity.Ext);
            comando.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Producto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}
