using System;

namespace Лабораторная_2._3
{
    class Book
    {
        public Author Author1 { get; set; }
        public Title Title1 { get; set; }
        public Content Content1 { get; set; }
        public Book(string AuthorName, string TitleBook, string ContentBook)
        {
            Author1 = new Author();
            Title1 = new Title();
            Content1 = new Content();

            Author1.AuthorName = AuthorName;
            Content1.ContentBook = ContentBook;
            Title1.TitleBook = TitleBook;
        }
        public void Show()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Author1.Show();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Title1.Show();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Content1.Show();
        }
        public Book()
        {
            Author1 = new Author();
            Title1 = new Title();
            Content1 = new Content();
        }
    }
    class Author
    {
        public string AuthorName
        {
            get; set;
        }
        public void Show()
        {
            Console.WriteLine($"Имя автора: {AuthorName}");
        }
    }
    class Title
    {
        public string TitleBook
        {
            get; set;
        }
        public void Show()
        {
            Console.WriteLine($"Название книги:{TitleBook}");
        }
    }
    class Content
    {
        public string ContentBook
        {
            get; set;
        }
        public void Show()
        {
            Console.WriteLine($"Описание книги:{ContentBook}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите автора:");
             string author = Console.ReadLine();

             Console.WriteLine("Введите название книги:");
             string title = Console.ReadLine();

             Console.WriteLine("О чем книга ");
             string content = Console.ReadLine();

             Book book = new Book(author, title, content);
             book.Show();

             Console.ReadLine();
        }
    }
}
