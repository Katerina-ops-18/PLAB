using System;

namespace lABORATORNA_2_2
{
    class Book
    {
        public Title title = new Title();
        public Author author = new Author();
        public Content content = new Content();
    }

    class Title
    {
        public string title = "Вода и мир";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Author
    {
        public string author = "Лев Толстой";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Content
    {
        public string content = "content";
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title.Show();
            book.author.Show();
            book.content.Show();
            Console.ReadKey();
        }
    }
}
