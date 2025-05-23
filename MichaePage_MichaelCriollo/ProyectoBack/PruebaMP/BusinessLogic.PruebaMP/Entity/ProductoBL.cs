using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.PruebaMP.Entity
{
    public class ProductoBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductoBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Producto producto)
        {
            _unitOfWork.Producto.Create(producto);
            _unitOfWork.Commit();
        }
    }
}
