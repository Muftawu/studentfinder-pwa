namespace api.domain;

public class User
{
    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public string UserId { get; set; } = Utilities.GenerateUserId();

    public string ReferenceNumber { get; set; } = Utilities.GenerateReferenceNumber();

    public string? Email { get; set; }

    public string? Programme { get; set; }

    public string? Gender { get; set;}

    public string? UserRole { get; set; }
    
    public DateTime? DateCreated { get; set; } =  DateTime.Now;
    
    public User ()
    {
    }

    public User (string fname, string lname)
    {
        FirstName = fname;
        LastName = lname;
        Email = Utilities.GenerateEmail(FirstName, LastName);
    }

}
