using EF013.TPH.Data;
using EF013.TPH.Entities;

namespace EF013.TPH
{
    class Program
    {
        public static void Main(string[] args)
        {
            var participant1 = new Individual
            {
                Id = 1,
                FName = "Ahmad",
                LName = "Ali",
                University = "JUST",
                YearOfGraduation = 2024,
                IsIntern = false
            };

            var participant2 = new Coporate
            {
                Id = 2,
                FName = "Ahmad",
                LName = "Ali",
                Company = "Metigator",
                JobTitle = "Developer"
            };

            using (var context = new AppDbContext())
            {
                context.Particpants.Add(participant1);
                context.Particpants.Add(participant2);
                context.SaveChanges();
            }

            using (var context = new AppDbContext())
            {
                Console.WriteLine("Coporate Participants");
                foreach (var participant in context.Set<Participant>().OfType<Coporate>())
                {
                    Console.WriteLine(participant);
                }
                Console.WriteLine("Individual Participants");

                foreach (var participant in context.Set<Participant>().OfType<Individual>())
                {
                    Console.WriteLine(participant);
                }
            }

            Console.ReadKey();
        }
    }
}

