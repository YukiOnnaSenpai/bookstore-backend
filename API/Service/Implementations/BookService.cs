using API.DAO.Classes;
using API.DAO.Converters;
using DAL.Model.Classes;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace API.Service.Implementations
{
    public class BookService : IService<BookDAO>
    {
        private readonly IRepository<Book, Guid> _repository;
        private readonly IConverter<Book, BookDAO> _converter;

        public BookService(IRepository<Book, Guid> repository, IConverter<Book, BookDAO> converter)
        {
            _repository = repository;
            _converter = converter;
        }
        public void Add(BookDAO dao)
        {
            Book entity = _converter.DaoToEntity(dao);
            _repository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public List<BookDAO> GetAll()
        {
            return _converter.EntityListToDaoList(_repository.GetAll());
        }

        public BookDAO GetById(Guid id)
        {
            return _converter.EntityToDao(_repository.GetByID(id));
        }

        public void Update(BookDAO dao)
        {
            _repository.Update(_converter.DaoToEntity(dao));
        }
    }
}
