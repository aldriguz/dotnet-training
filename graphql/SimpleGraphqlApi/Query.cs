namespace SimpleGraphqlApi
{
    public class Query
    {
        public Book GetBook() => new Book() { Tittle = "His Dark Material", Author = "Unknown" };
    }
}
