using System.Xml.Linq;

try
{
    XElement rootElement = XElement.Load("contacts.xml");

    var contacts = from contact in rootElement.Descendants("contact")
                   select contact;

    foreach ( var contact in contacts)
    {
        Console.WriteLine(contact.Attribute("firstname").Value);
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	throw;
}

