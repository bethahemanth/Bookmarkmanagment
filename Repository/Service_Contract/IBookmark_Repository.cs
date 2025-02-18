using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public interface IBookmark_Repository
    {
        public string createBookmark();
        string InsertBookmark(Bookmark bookmark);
        string DeleteBookmarkById(int id);
        string UpdateBookmarkById(int id, Bookmark bookmark);
        List<Bookmark> GetAllBookmarks();
        Bookmark GetBookmarkById(int id);

    }
}
