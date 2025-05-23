using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.PruebaMP.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlConnection _conexion;
        private readonly SqlTransaction _transaccion;

        private ClienteDA _clienteDA;
        private ProductoDA _productoDA;

        public UnitOfWork(IConfiguration configuration)
        {
            var cadena = configuration.GetConnectionString("PruebaMPDB")!;
            _conexion = new SqlConnection(cadena);
            _conexion.Open();
            _transaccion = _conexion.BeginTransaction();
        }

        public ICliente Cliente =>
            _clienteDA ??= new ClienteDA(_conexion, _transaccion);

        public IBase<Producto> Producto =>
            _productoDA ??= new ProductoDA(_conexion, _transaccion);


        public void Commit()
        {
            _transaccion.Commit();
            _conexion.Close();
        }

        public void Dispose()
        {
            _transaccion.Dispose();
            _conexion.Dispose();
        }
    }

}
