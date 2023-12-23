using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task2
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Название книги: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Стоимость: {price}руб.");
        }
    }

    public class BookGenre : Book
    {
        private string genre;

        public BookGenre(string title, string author, double price, string genre)
            : base(title, author, price)
        {
            this.genre = genre;
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Жанр: {genre}");
        }
    }

    sealed public class BookGenrePubl : BookGenre
    {
        private string publisher;

        public BookGenrePubl(string title, string author, double price, string genre, string publisher)
            : base(title, author, price, genre)
        {
            this.publisher = publisher;
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Издательство: {publisher}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BookGenrePubl book = new BookGenrePubl("Война и мир", "Л.Н. Толстой", 300, "Роман", "Эксмо");
            book.Print();
            Console.WriteLine();
            BookGenrePubl book1= new BookGenrePubl("Колобок", "А.Н. Толстой", 20, "Народная сказка", "Эксмо");
            book1.Print();
            Console.ReadLine();
        }

    }
}
