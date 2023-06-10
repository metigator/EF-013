using EF013.TPC.Data;
using EF013.TPC.Entities;

namespace EF013.TPC
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

            var participant3 = new Coporate
            {
                Id = 3,
                FName = "Reem",
                LName = "Ali",
                Company = "Metigator",
                JobTitle = "QA"
            };


            using (var context = new AppDbContext())
            {
                context.Particpants.Add(participant1);
                context.Particpants.Add(participant2);
                context.Particpants.Add(participant3);
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

