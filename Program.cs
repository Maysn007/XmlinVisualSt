using ContactApp;
using System.Xml.Linq;

try
{
    XElement rootElement = XElement.Load("contacts.xml");

    var contacts = from contact in rootElement.Descendants("contact")
                   select new Contact(contact.Attribute("firstname").Value,
                   contact.Attribute("lastname").Value,
                   contact.Attribute("phone").Value)
                   { Mail = contact.Attribute("mail").Value};

    foreach (var contact in contacts)
    {
        Console.WriteLine(contact.FirstName);
        Console.WriteLine(contact.LastName);
        Console.WriteLine(contact.Phone);
        Console.WriteLine(contact.Mail);
        Console.WriteLine();
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

