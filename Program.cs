namespace bookStoreRecord
{
    internal class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore bookstore1 = new(1, "To Kill a Mockingbird", "Harper Lee", 9.99);
            Bookstore bookstore2 = new(2, "1984", "George Orwell", 8.99);
            Bookstore bookstore3 = new(3, "The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            Console.WriteLine(bookstore1);
            Console.WriteLine(bookstore2);
            Console.WriteLine(bookstore3);
        }
    }
}