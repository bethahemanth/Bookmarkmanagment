using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repository;
namespace Services
{
    public class Bookmark_Service :IBookmark_Service
    {
        private readonly IBookmark_Repository _bookmarkRepository;
        public Bookmark_Service(IBookmark_Repository bookmarkRepository)
        {
            _bookmarkRepository = bookmarkRepository;
        }
        public string createBookmark()
        {
            return _bookmarkRepository.createBookmark();
        }
        public string InsertBookmark(Bookmark bookmark)
        {
            return _bookmarkRepository.InsertBookmark(bookmark);
        }

        public string DeleteBookmarkById(int id)
        {
            return _bookmarkRepository.DeleteBookmarkById(id);
        }

        public string UpdateBookmarkById(int id, Bookmark bookmark)
        {
            return _bookmarkRepository.UpdateBookmarkById(id, bookmark);
        }

        public List<Bookmark> GetAllBookmarks()
        {
            return _bookmarkRepository.GetAllBookmarks();
        }

        public Bookmark GetBookmarkById(int id)
        {
            return _bookmarkRepository.GetBookmarkById(id);
        }


    }
}
