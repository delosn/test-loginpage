using System.Data.SqlClient;


namespace test_loginpage.Models
  
{
    public class dataAccess
    {

        private readonly IConfiguration _configuration;

        public dataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<UserInfo> UserSelect()
        {
            List<UserInfo> list = new List<UserInfo>();

            string connectionString = _configuration.GetValue<string>("ConnectionStrings:mySQLServer");


            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                conn.Open();
                string commandtext = "select FirstName, LastName from dbo.testConnection";

                SqlCommand cmd = new SqlCommand(commandtext, conn);

                var reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    UserInfo listValue = new UserInfo()
                    {
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString()

                    };

                    list.Add(listValue);
                }

                conn.Close();
            }
            return list;
        }
    }
}







//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();
//    // Do work here; connection closed on following line.
//}



//var _config = app.Services.GetRequiredService<IConfiguration>();
//var connectionstring = _config.GetConnectionString("DefaultConnection");
////build the sqlconnection and execute the sql command
//using (SqlConnection conn = new SqlConnection(connectionstring))
//{
//    conn.Open();
//    string commandtext = "select MovieId, Title, Genre from Movie";

//    SqlCommand cmd = new SqlCommand(commandtext, conn);

//    var reader = cmd.ExecuteReader();

//    while (reader.Read())
//    {
//        var movie = new Movie()
//        {
//            MovieId = Convert.ToInt32(reader["MovieId"]),
//            Title = reader["Title"].ToString(),
//            Genre = reader["Genre"].ToString()
//        };

//        movies.Add(movie);
//    }
//}
//return movies;
//});



//public class HomeController : Controller
//{
//    private readonly ILogger<HomeController> _logger;
//    private readonly IConfiguration _configuration;
//    public HomeController(ILogger<HomeController> logger, IConfiguration Configuration)
//    {
//        _logger = logger;
//        _configuration = Configuration;
//    }

//    public IActionResult Index()
//    {
//        List<BookModel> books = GetBookList();
//        return View(new SelectList(books, "BookId", "BookName"));
//    }
//    [HttpPost]
//    public IActionResult Index(string BookId, string BookName)
//    {
//        ViewBag.Message = "Book Name: " + BookName;
//        ViewBag.Message += "\\nBook Id: " + BookId;

//        List<BookModel> books = GetBookList();
//        return View(new SelectList(books, "BookId", "BookName"));
//    }

//    private List<BookModel> GetBookList()
//    {
//        string constr = _configuration.GetConnectionString("DefaultConnection");
//        List<BookModel> books = new List<BookModel>();
//        using (SqlConnection con = new SqlConnection(constr))
//        {
//            string query = "SELECT BookId,BookName FROM Books";
//            using (SqlCommand cmd = new SqlCommand(query))
//            {
//                cmd.Connection = con;
//                con.Open();
//                using (SqlDataReader sdr = cmd.ExecuteReader())
//                {
//                    while (sdr.Read())
//                    {
//                        books.Add(new BookModel /*<-- Could do it like this?*/
//                        {
//                            BookName = sdr["BookName"].ToString(),
//                            BookId = Convert.ToInt32(sdr["BookId"])
//                        });
//                    }
//                }
//                con.Close();
//            }
//        }
//        return books;
//    }
//}