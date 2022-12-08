using System;
using System.Collections.Generic;

namespace NorthwindData.Models;

public partial class Product {
    public override string? ToString() {
        return $"{ProductId} {ProductName}";
    }
}
