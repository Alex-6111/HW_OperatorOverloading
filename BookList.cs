using System;
using System.Text;
using static System.Console;
using System.Collections.Generic;

namespace HW_OperatorOverloading
{
    public class BookList
    {
        private  List<Book> books;

        public BookList()
        {
            BookList = new List<Book>();
        }

        public Book this[int index] {
            get {
                if (index > 0 || index <= BookList.Count)
                {
                    return BookList[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set {
                BookList[index] = value;

            }
        }
        public static BookList operator +(BookList list, Book book)
        {
            list.BookList.Add(book);
            return list;
        }
        public static BookList operator -(BookList list, Book book)
        {
            list.BookList.Remove(book);
            return list;
        }
        public bool IsExist(string? NameOfBook)
        {
            Book book = new Book();

            if (book == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                foreach (Book book in BookList)
                {
                    if (book.Title == NameOfBook)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrintList()
        {
            int count = 1;
            if (this.BookList.Count == 0)
            {

                WriteLine("List is empty!");
            }
            else
            {
                foreach (Book book in this.BookList)
                {
                    Write(count);
                    WriteLine(book.ToString());
                    count++;
                }
            }
        }
        public int Length()
        {
            return this.BookList.Count;
        }

    }

    public class Book
    {
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Author { get; set; }

        public Book(string? name, int? price, string? author) : this()
        {
            Name = name;
            Price = price;
            Author = author;
        }

        public Book()
        {
            Name = null;
            Price = null;
            Author = null;
        }

        public void EnterInfo()
        {
            Write("Name -> "); Name = ReadLine();
            Write("Price -> "); Price = Convert.ToInt32(ReadLine());
            Write("Author -> "); Author = ReadLine();
        }

        public void OutInfo()
        {
            WriteLine($"Name -> {Name}\n" +
                $"Price -> {Price}\n" +
                $"Author -> {Author}");
        }
    }
}
