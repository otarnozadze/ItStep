using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
}

class BookManager
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author, int publicationYear)
    {
        Book newBook = new Book
        {
            Title = title,
            Author = author,
            PublicationYear = publicationYear
        };

        books.Add(newBook);
        Console.WriteLine("Book added successfully!");
    }

    public void ShowAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the list.");
        }
        else
        {
            Console.WriteLine("List of Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}");
            }
        }
    }

    public void SearchBookByTitle(string title)
    {
        Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (foundBook != null)
        {
            Console.WriteLine($"Book found - Title: {foundBook.Title}, Author: {foundBook.Author}, Year: {foundBook.PublicationYear}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        BookManager bookManager = new BookManager();

        while (true)
        {
            Console.WriteLine("\nBook Management Console");
            Console.WriteLine("1. Please Add a new book");
            Console.WriteLine("2. View all books");
            Console.WriteLine("3. Search for a book by title");
            Console.WriteLine("4. Exit");

            Console.Write("Please enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Please enter book title: ");
                    string title = Console.ReadLine();

                    Console.Write("Please enter author name: ");
                    string author = Console.ReadLine();

                    Console.Write("Please enter publication year: ");
                    int publicationYear;
                    while (!int.TryParse(Console.ReadLine(), out publicationYear))
                    {
                        Console.Write("Please enter a valid year: ");
                    }

                    bookManager.AddBook(title, author, publicationYear);
                    break;

                case "2":
                    bookManager.ShowAllBooks();
                    break;

                case "3":
                    Console.Write("Enter the title of the book to search: ");
                    string searchTitle = Console.ReadLine();
                    bookManager.SearchBookByTitle(searchTitle);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}
