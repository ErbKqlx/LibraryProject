using System;
using System.Collections.Generic;

namespace LibraryProject.Models;

public partial class User
{
    public long Id { get; set; }

    public short IdRole { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string Ticket { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Role IdRoleNavigation { get; set; } = null!;
}
