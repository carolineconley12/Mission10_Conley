using System;
using System.Collections.Generic;

namespace WebApplicationAPI.Models;

public partial class ZtblWeek
{
    public DateOnly WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
