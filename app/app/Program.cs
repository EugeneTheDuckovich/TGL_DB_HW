using Microsoft.EntityFrameworkCore;
using src.db;

namespace src;

internal class Program
{
    static void Main(string[] args)
    {
        var puppiesContext = new PuppiesContext();
        Initialize(puppiesContext);
        var owner = puppiesContext.Owners.Include(owner => owner.Puppies).First();
        Console.WriteLine(
            $"owner {owner.Name} that lives at {owner.Address} " +
            $"has {owner.Puppies.Count} puppies:");
        foreach (var puppy in owner.Puppies)
        {
            Console.WriteLine($"{puppy.Name}, {puppy.Breed}, {puppy.Height} cm, {puppy.Weight} kg");
        }
    }

    public static void Initialize(PuppiesContext puppiesContext)
    {


        if (puppiesContext.Owners.Count() == 0)
        {
            var owner = new Owner
            {
                Id = 1,
                Name = "Vadim",
                Address = "Lviv"
            };
            puppiesContext.Owners.Add(owner);
            puppiesContext.SaveChanges();
        }

        if (puppiesContext.Puppies.Count() == 0)
        {
            var puppy = new Puppy
            {
                Id = 1,
                Name = "Svetka",
                Height = 15,
                Weight = 2,
                Breed = "Chihuahua",
                Owner = puppiesContext.Owners.First()
            };
            puppiesContext.Puppies.Add(puppy);
            puppiesContext.SaveChanges();
        }
    }
}