using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.PruebaMP.Entity
{
    public class ClienteDA : ICliente
    {
        private readonly SqlConnection _conexion;
        private readonly SqlTransaction _transaccion;

        public ClienteDA(SqlConnection conexion, SqlTransaction transaccion)
        {
            _conexion = conexion;
            _transaccion = transaccion;
        }

        public IEnumerable<Cliente> GetAll()
        {
            var lista = new List<Cliente>();

            using var comando = new SqlCommand("sp_GetAllClientes", _conexion, _transaccion)
            {
                CommandType = CommandType.StoredProcedure
            };

            using var read = comando.ExecuteReader();
            while (read.Read())
            {
                lista.Add(new Cliente
                {
                    Id = Convert.ToInt32(read["Id"]),
                    RazonSocial = read["RazonSocial"].ToString()!,
                    IdTipoCliente = Convert.ToInt32(read["IdTipoCliente"])!
                });
            }

            return lista;
        }
    }
}
