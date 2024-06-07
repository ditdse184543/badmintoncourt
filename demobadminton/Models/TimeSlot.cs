﻿using System;
using System.Collections.Generic;

namespace demobadminton.Models;

public partial class TimeSlot
{
    public int TsId { get; set; }

    public DateOnly TsDate { get; set; }

    public TimeOnly TsStart { get; set; }

    public TimeOnly TsEnd { get; set; }

    public bool TsCheckedIn { get; set; }

    public int CoId { get; set; }

    public int AId { get; set; }

    public int BId { get; set; }

    public virtual Booking BIdNavigation { get; set; } = null!;

    public virtual Court Co { get; set; } = null!;
}
