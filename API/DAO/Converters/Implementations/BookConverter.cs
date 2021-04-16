using API.DAO.Classes;
using DAL.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DAO.Converters.Implementations
{
    public class BookConverter : IConverter<Book, BookDAO>
    {
        public BookConverter() { }
        public List<Book> DaoListToEntityList(List<BookDAO> daos)
        {
            List<Book> entities = new List<Book>();
            foreach (BookDAO dao in daos)
            {
                entities.Add(DaoToEntity(dao));
            }
            return entities;
        }

        public Book DaoToEntity(BookDAO dao)
        {
            Book entity = new Book
            {
                BookID = dao.BookID,
                ISBN = dao.ISBN,
                Author = dao.Author,
                Genre = dao.Genre,
                Title = dao.Title,
                IsDeleted = dao.IsDeleted
            };
            return entity;
        }

        public List<BookDAO> EntityListToDaoList(List<Book> entities)
        {
            List<BookDAO> daos = new List<BookDAO>();
            foreach (Book entity in entities)
            {
                daos.Add(EntityToDao(entity));
            }
            return daos;
        }

        public BookDAO EntityToDao(Book entity)
        {
            BookDAO dao = new BookDAO
            {
                BookID = entity.BookID,
                ISBN = entity.ISBN,
                Author = entity.Author,
                Genre = entity.Genre,
                Title = entity.Title,
                IsDeleted = entity.IsDeleted
            };
            return dao;
        }
    }
}
