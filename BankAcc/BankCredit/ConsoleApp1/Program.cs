using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication390
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTowns();
            List<Group> groups = DistributeStudentsInGroups(towns);

            PrintGroups(groups);


        }

        static List<Town> ReadTowns()
        {
            List<Town> towns = new List<Town>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    Town currentTown = new Town();
                    string[] name = input.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).ToArray();



                    currentTown.Name = name[0].Trim();
                    name[1] = name[1].Trim();

                    string[] seats = name[1].Split();

                    currentTown.SeatsCount = int.Parse(seats[0]);
                    currentTown.Students = new List<Student>();
                    towns.Add(currentTown);
                }

                else
                {
                    string[] info = input.Split(new char[] { '|', }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                    Student currentStudent = new Student();
                    currentStudent.Name = info[0];
                    currentStudent.Email = info[1];
                    currentStudent.RegistrationDate = DateTime.ParseExact(info[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns.Last().Students.Add(currentStudent);
                }

                input = Console.ReadLine();
            }
            return towns;
        }

        static List<Group> DistributeStudentsInGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();


            foreach (var town in towns)
            {

                IEnumerable<Student> students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(z => z.Name).ThenBy(y => y.Email);

                while (students.Any())
                {

                    Group currentGroup = new Group();
                    currentGroup.Town = town;
                    currentGroup.Students = students.Take(town.SeatsCount).ToList();
                    students.Skip(town.SeatsCount);

                    groups.Add(currentGroup);
                }
            }

            return groups;
        }

        static void PrintGroups(List<Group> groups)
        {


            foreach (var group in groups.OrderBy(g => g.Town))
            {
                Console.Write(group.Town.Name);
                Console.Write(" => ");
                Console.WriteLine(string.Join(", ", group.Students.Select(x => x.Email)));
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }

}