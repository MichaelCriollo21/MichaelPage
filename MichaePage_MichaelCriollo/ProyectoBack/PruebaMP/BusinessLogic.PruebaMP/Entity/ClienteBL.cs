using DataAccess.PruebaMP.Interface;
using Entity.PruebaMP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.PruebaMP.Entity
{
    public class ClienteBL
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Cliente> FindAll() => _unitOfWork.Cliente.GetAll();
    }
}
