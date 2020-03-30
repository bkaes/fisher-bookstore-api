using System.Collections.Generic;
using Fisher.Bookstore.Models;
namespace Fisher.Bookstore.Services
{

    public interface IAuthorsRepository
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(int authorId);
        int AddAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int authorId);
        bool AuthorExists(int authorId);
    }
}