using System;
using System.Collections.Generic;

namespace DTO.Classes;

public partial class UserDto
{
    public int UserId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    
}
