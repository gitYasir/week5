using System;
using System.Collections.Generic;

namespace EntityFramworksHW.Models;

public partial class Trainee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Course { get; set; }

    public string? Location { get; set; }

    public string? FavHobby { get; set; }
}
