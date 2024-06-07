using System;
using System.Collections.Generic;

namespace demobadminton.Models;

public partial class Court
{
    public int CoId { get; set; }

    public string CoName { get; set; } = null!;

    public string CoAddress { get; set; } = null!;

    public string CoInfo { get; set; } = null!;

    public int AId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
}
