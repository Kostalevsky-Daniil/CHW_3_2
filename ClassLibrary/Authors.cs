namespace ClassLibrary;

public class Authors
{
    private string _authorId;
    private string _name;
    private double _earnings;
    private List<Books> _books;

    public Authors()
    {
        
    }    
    
    public Authors(string authorId, string name, double earnings, List<Books> books)
    {
        _authorId = authorId;
        _name = name;
        _earnings = earnings;
        _books = books;
    }

    public string AuthorId { get; }
    public string Name { get; }
    public double Earnings { get; }
    public List<Books> Books { get; }
}

public class Books : Authors
{
    private string _bookId;
    private string _title;
    private int _publicationYear;
    private string _genre;
    private double _earnings;

    public Books()
    {
        
    }

    public Books(string bookId, string title, int publicationYear, string genre, double earnings)
    {
        _bookId = bookId;
        _title = title;
        _publicationYear = publicationYear;
        _genre = genre;
        _earnings = earnings;
    }

    public string BookId { get; }
    public string Title { get; }
    public int PublicationYear { get; }
    public string Genre { get; }
    public double Earnings { get; }
}