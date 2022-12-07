using System;
using System.Collections.Generic;

namespace NorthwindData.Models;

public partial class Spartan
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? UniverityAttended { get; set; }

    public string? CourseTaken { get; set; }

    public string? MarkAchieved { get; set; }

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;
}
