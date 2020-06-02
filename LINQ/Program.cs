using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student() {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
                new Student() {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
                new Student() {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
                new Student() {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
                new Student() {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
                new Student() {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
                new Student() {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
                new Student() {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
                new Student() {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
                new Student() {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
                new Student() {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
                new Student() {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
            };
            
            // Create the query.
            // The first line could also be written as "var studentQuery ="
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                orderby student.Last ascending 
                select student;
            
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }

            
            // Testing with real information
            List<Player> players = new List<Player>
            {
                new Player(1, 1, "Eduardo", new DateTime(1978, 02, 12), 150, 50000),
                new Player(2, 1, "José", new DateTime(1987, 05, 25), 85, 35000),
                new Player(11, 1, "Paulo", new DateTime(1990, 01, 05), 68, 25000),
                new Player(27, 1, "Renato", new DateTime(1991, 08, 27), 150, 30000),
                new Player(32, 1, "Wesley", new DateTime(1985, 04, 18), 87, 37000)
            };

            IEnumerable<Player> playerQuery =
                from player in players
                where player.SkillLevel > 80
                orderby player.Id ascending
                select player;

            foreach (var player in playerQuery)
            {
                Console.WriteLine(player.Id);
            }
            
            IEnumerable<Player> itemMax =
                (from i in players
                    let maxId = players.Max(m => m.SkillLevel)
                    let minId = players.Min(n => n.Id)
                    where i.SkillLevel == maxId
                    select i);

            
            Console.WriteLine("TESTE DE NOVO");
            var lista =
                from i in itemMax
                let minId = itemMax.Min(t => t.Id)
                where i.Id == minId
                select i;

            foreach (var sei in lista)
            {
                Console.WriteLine(sei.Name);
            }
            
            Console.WriteLine("TESTE MAIS UMA VEZ");
            var saida =
                from i in players
                let maxId = players.Max(t=>t.SkillLevel)
                where i.SkillLevel == maxId
                orderby i.Id ascending
                select i;
            

            var outro = saida.First();
            Console.WriteLine(outro.Name);
        }
    }
}