using Entity.PruebaMP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.PruebaMP.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IBase<Producto> Producto { get; }
        ICliente Cliente { get; }
        void Commit();
    }
}
