using DataBase;
using Domain;

namespace Repository
{
    public class Bookmark_Repository:IBookmark_Repository
    {
        private readonly IDatabaseContext _context;
        public Bookmark_Repository(IDatabaseContext context)
        {
            _context = context;
        }

        public string createBookmark()
        {
            string query = $@"CREATE TABLE ""bookmark_p"" (
                        ""Id"" INT PRIMARY KEY,
                        ""Url"" VARCHAR(255),
                        ""Title"" VARCHAR(255),
                        ""Description"" TEXT,
                        ""CreatedAt"" TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                        ""UserId"" INT,
                        CONSTRAINT fk_user FOREIGN KEY (""UserId"") REFERENCES ""users_p""(""id"")
                     );";
            return _context.ExecuteQuery(query);
        }


        public string InsertBookmark(Bookmark bookmark)
        {
            string query = $@"
        INSERT INTO ""bookmark_p"" (""Id"",""Url"", ""Title"", ""Description"", ""UserId"") 
        VALUES ('{bookmark.Id}','{bookmark.Url}', '{bookmark.Title}', '{bookmark.Description}', {bookmark.UserId});
    ";
            return _context.ExecuteQuery(query);
        }


        public string DeleteBookmarkById(int id)
        {
            string query = $@"DELETE FROM bookmark_p WHERE ""Id"" = {id};";
            return _context.ExecuteQuery(query);
        }

        public string UpdateBookmarkById(int id, Bookmark bookmark)
        {
            string query = $@"UPDATE bookmark_p 
                      SET ""Url"" = '{bookmark.Url}', ""Title"" = '{bookmark.Title}', ""Description"" = '{bookmark.Description}'
                      WHERE ""Id"" = {id};";
            return _context.ExecuteQuery(query);
        }

        public List<Bookmark> GetAllBookmarks()
        {
            string query = $@"SELECT * FROM ""bookmark_p""";
            return _context.GetTableData<Bookmark>(query);
        }

        public Bookmark GetBookmarkById(int id)
        {
            string query = $@"SELECT * FROM bookmark_p WHERE ""Id"" = {id}";
            return _context.GetTableData<Bookmark>(query).FirstOrDefault();
        }

    }
}
