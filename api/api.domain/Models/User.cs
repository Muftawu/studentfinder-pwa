namespace api.domain;

public class User
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Email { get; set; }
    public string? Programme { get; set; }
    public string? Gender { get; set;}
    public string? UserRole { get; set; }
    public DateTime? DateCreated { get; set; }
    
    public User ()
    {

    }

    public User (string fname, string lname)
    {
        FirstName = fname;
        LastName = lname;
        ReferenceNumber = Utilities.GenerateReferenceNumber();
        Email = Utilities.GenerateEmail(FirstName, LastName);
        DateCreated = DateTime.Now;
    }

}
