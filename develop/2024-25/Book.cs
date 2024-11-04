using System;
using System.Collections.Generic;

public class Book
{
    // Soukromé atributy
    private string author;
    private string title;
    private string isbn;
    private string language;
    private string publisher;

    // Veřejné vlastnosti pro přístup k atributům
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public string Language
    {
        get { return language; }
        set { language = value; }
    }

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

    // Konstruktor pro pohodlné vytvoření objektu
    public Book(string author, string title, string isbn, string language, string publisher)
    {
        this.author = author;
        this.title = title;
        this.isbn = isbn;
        this.language = language;
        this.publisher = publisher;
    }

    // Statická metoda pro vygenerování seznamu 50 knih
    public static List<Book> GenerateSampleBooks()
    {
        List<Book> books = new List<Book>();

        // Seznamy pro náhodná data
        string[] authors = { "J.K. Rowling", "J.R.R. Tolkien", "George Orwell", "Agatha Christie", "Stephen King", "Isaac Asimov", "Arthur C. Clarke", "Jane Austen", "Mark Twain", "Ernest Hemingway" };
        string[] titles = { "Mystery of the Unknown", "The Lost World", "Adventures in Wonderland", "Dystopian Dreams", "Haunted Nights", "Robots of Tomorrow", "The Star Journey", "Pride and Prejudice", "The Great Adventure", "Into the Wild" };
        string[] languages = { "English", "Czech", "Spanish", "German", "French", "Japanese" };
        string[] publishers = { "HarperCollins", "Penguin Books", "Random House", "Oxford Press", "Vintage", "Simon & Schuster" };

        Random random = new Random();

        // Generování 50 knih s náhodnými daty
        for (int i = 0; i < 50; i++)
        {
            string author = authors[random.Next(authors.Length)];
            string title = titles[random.Next(titles.Length)] + " " + (i + 1); // Aby se názvy lišily
            string isbn = "978-" + random.Next(100000000, 999999999).ToString();
            string language = languages[random.Next(languages.Length)];
            string publisher = publishers[random.Next(publishers.Length)];

            books.Add(new Book(author, title, isbn, language, publisher));
        }

        return books;
    }
}

