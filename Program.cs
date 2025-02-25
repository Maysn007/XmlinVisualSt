using ContactApp;
using System.Xml.Linq;

try
{
    XElement rootElement = XElement.Load("contacts.xml");

    var contacts = from contact in rootElement.Descendants("contact")
                   select new Contact(contact.Attribute("firstname").Value,
                   contact.Attribute("lastname").Value,
                   contact.Attribute("phone").Value)
                   { Mail = contact.Attribute("mail")?.Value ?? ""};

    foreach (var contact in contacts)
    {
        Console.WriteLine(contact.FirstName);
        Console.WriteLine(contact.LastName);
        Console.WriteLine(contact.Phone);
        Console.WriteLine(contact.Mail);
        Console.WriteLine();
    }

    var contact1 = new Contact("John", "Cena", "124512532");
    var contactElement = new XElement("contact");

    var firstnameAttribute = new XAttribute("firstname", contact1.FirstName);
    contactElement.Add(firstnameAttribute);

    var lastnameAttribute = new XAttribute("lastname", contact1.LastName);
    contactElement.Add(lastnameAttribute);

    var phoneAttribute = new XAttribute("phone", contact1.Phone);
    contactElement.Add(phoneAttribute);

    rootElement.Add(contactElement);
    rootElement.Save("contacts.xml");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

