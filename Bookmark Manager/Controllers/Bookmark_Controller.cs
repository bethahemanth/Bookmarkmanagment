using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
namespace Bookmark_Manager.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Bookmark_Controller : ControllerBase
    {
        private readonly IBookmark_Service _book;
        public Bookmark_Controller(IBookmark_Service book)
        {
            _book = book;
        }

        [HttpPost]
        [ActionName("InsertBookmark")]
        public string InsertBookmark([FromBody] Bookmark bookmark)
        {
            return _book.InsertBookmark(bookmark);
        }

        [HttpPost]
        [ActionName("CreateBookmark")]
        public string createBookmark()
        {
            return _book.createBookmark();
        }


        [HttpDelete()]
        [ActionName("DeleteBookmarkById")]
        public string DeleteBookmarkById(int id)
        {
            return _book.DeleteBookmarkById(id);
        }

        [HttpPut()]
        [ActionName("UpdateBookmarkById")]
        public string UpdateBookmarkById(int id, [FromBody] Bookmark bookmark)
        {
            return _book.UpdateBookmarkById(id, bookmark);
        }

        [HttpGet]
        [ActionName("GetAllBookmarks")]
        public List<Bookmark> GetAllBookmarks()
        {
            return _book.GetAllBookmarks();
        }

        [HttpGet]
        [ActionName("GetBookmarkById")]
        public Bookmark GetBookmarkById(int id)
        {
            return _book.GetBookmarkById(id);
        }


    }
}
