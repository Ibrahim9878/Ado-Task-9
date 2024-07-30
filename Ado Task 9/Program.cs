using Ado_Task_9;
using System.Data.SqlClient;

IAuthorRepository repo = new AuthorRepository(new SqlConnection(),
    @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");

//var author = repo.Add(new Author() { FirstName = "Neil", LastName = "Gaiman" });
//var author2 = repo.Add(new Author() { FirstName = "Zahid", LastName = "Xelil" });
//Console.WriteLine(author2);

//Console.WriteLine(repo.GetById(13));
//repo.Remove(18);
//repo.Update(new Author { Id = 16, FirstName = "Nadir", LastName = "Zaman" });
//repo.AddAuthors(new List<Author>()
//{
//    new Author() {FirstName = "Huseyn",LastName = "Memmedov"},
//    new Author() {FirstName = "Maga",LastName = "Fetullayev"},
//    new Author() {FirstName = "Ibrahim",LastName = "Talibli"}
//});
//repo.RemoveByIdArray([15,16,17]);
//repo.RemoveRange(18, 20);
repo.UpdateAuthors(new List<Author>()
{
    new Author() {Id = 1,FirstName = "Huseyn",LastName = "Memmedov"},
    new Author() {Id = 2,FirstName = "Maga",LastName = "Fetullayev"},
    new Author() {Id = 3,FirstName = "Ibrahim",LastName = "Talibli"}
});
repo.GetAll().ToList().ForEach(Console.WriteLine);