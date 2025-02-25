namespace ContactApp;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }

    public Contact(string firstname, string lastname, string phone)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Phone = phone;
    }
}

