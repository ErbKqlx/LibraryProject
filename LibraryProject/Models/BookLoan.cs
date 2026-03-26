using System;
using System.Collections.Generic;

namespace LibraryProject.Models;

public partial class BookLoan
{
    public long Id { get; set; }

    public long IdUser { get; set; }

    public long IdBook { get; set; }

    public DateOnly GiveDate { get; set; }

    public DateOnly ReturnDatePlanned { get; set; }

    public DateOnly? ReturnDateReal { get; set; }

    public short IdStatus { get; set; }

    public virtual Book IdBookNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
