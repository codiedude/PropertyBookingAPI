using System;
using System.Collections.Generic;

namespace PropertyBookingAPI.Models;

public partial class Booking
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public int PropertyId { get; set; }

    public DateTime BookingDate { get; set; }

    public virtual Property Property { get; set; } = null!;

    public virtual AspNetUser User { get; set; } = null!;
}
