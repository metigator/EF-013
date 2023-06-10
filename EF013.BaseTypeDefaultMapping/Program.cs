using EF013.BaseTypeDefaultMapping.Data;
using Microsoft.EntityFrameworkCore;

namespace EF013.BaseTypeDefaultMapping
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {

                var sections = context.Sections
                    .Include(x => x.Course)
                    .Include(x => x.Instructor)
                    .Include(x => x.Schedule);

                Console.WriteLine("| Id |  Course      | Section | Instructor           | Schedule       | Time Slot     | SUN | MON | TUE | WED | THU | FRI | SAT |");
                Console.WriteLine("|----|--------------|---------|----------------------|----------------|---------------|-----|-----|-----|-----|-----|-----|-----|");

                foreach (var section in sections)
                {
                    string sunday = section.Schedule.SUN ? " x" : "";
                    string monday = section.Schedule.MON ? " x" : "";
                    string tuesday = section.Schedule.TUE ? " x" : "";
                    string wednesday = section.Schedule.WED ? " x" : "";
                    string thursday = section.Schedule.THU ? " x" : "";
                    string friday = section.Schedule.FRI ? " x" : "";
                    string saturday = section.Schedule.SAT ? " x" : "";

                    Console.WriteLine($"| {section.Id.ToString().PadLeft(2, '0')} | {section.Course.CourseName,-12} | {section.SectionName,-7} | {section.Instructor?.FName + " " + section.Instructor?.LName,-20} | {section.Schedule.Title,-14} | {section.TimeSlot,-9} | {sunday,-3} | {monday,-3} | {tuesday,-3} | {wednesday,-3} | {thursday,-3} | {friday,-3} | {saturday,-3} |");
                }
            }

            Console.ReadKey();
        }
    }
}

