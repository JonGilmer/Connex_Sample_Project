using Connex_Sample_Project.Models;
using System.Linq;

using (var db = new connex_sample_projectContext())
{
    var querySampleUser = db.SampleUsers;

    foreach (var user in querySampleUser)
    { 
        Console.WriteLine("First Name: " + user.FirstName);
        Console.WriteLine("Last Name: " + user.LastName);
        Console.WriteLine("Timestamp: " + user.Timestamp);
    }

    Console.ReadLine();
};