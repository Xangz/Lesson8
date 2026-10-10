using System;
using System.Collections.Generic;

namespace NdsLesson08.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public string? OrderId { get; set; }

    public string? BookId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? TotalMoney { get; set; }

    public virtual Book? Book { get; set; }

    public virtual OrderBook? Order { get; set; }
}
