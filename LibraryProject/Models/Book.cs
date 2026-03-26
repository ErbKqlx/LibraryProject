using System;
using System.Collections.Generic;

namespace LibraryProject.Models;

public partial class Book
{
    public long Id { get; set; }

    public string Isbn { get; set; } = null!;

    public string BookName { get; set; } = null!;

    public int IdAuthor { get; set; }

    public short IdGenre { get; set; }

    public int IdPublisher { get; set; }

    public short PageCount { get; set; }

    public short TotalAmount { get; set; }

    public short AvailableAmount { get; set; }

    public string Annotation { get; set; } = null!;

    public short PublishYear { get; set; }

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Author IdAuthorNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual Publisher IdPublisherNavigation { get; set; } = null!;
}
