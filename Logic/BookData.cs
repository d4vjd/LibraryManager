using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class BookData
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Publisher { get; set; }
    public string Genre { get; set; }
    public string Summary { get; set; }
    public string CoverImage { get; set; }
    public double Rating { get; set; }
    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
}

