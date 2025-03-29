using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public interface IBookmark_Service
    {
        public string createBookmark();
        string InsertBookmark(Bookmark bookmark);
        string DeleteBookmarkById(int id);
        string UpdateBookmarkById(int id, Bookmark bookmark);
        List<Bookmark> GetAllBookmarks();
        Bookmark GetBookmarkById(int id);


    }
}
