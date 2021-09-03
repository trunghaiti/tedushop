using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IFooterService
    {
        Footer Add(Footer footer);
        void Update(Footer footer);
        Footer Delete(string id);
        IEnumerable<Footer> GetAll();
        IEnumerable<Footer> GettAllPaging(int page, int pageSize, out int totalRow);
        Footer GetById(int id);
        void Commit();
    }
    class FooterService : IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }

        public Footer Add(Footer footer)
        {
            return _footerRepository.Add(footer);
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        public Footer Delete(string id)
        {
            return _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public Footer GetById(int id)
        {
            return _footerRepository.GetSingleById(id);
        }

        public IEnumerable<Footer> GettAllPaging(int page, int pageSize, out int totalRow)
        {
            return _footerRepository.GetMultiPaging(null, out totalRow, page, pageSize);
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}
