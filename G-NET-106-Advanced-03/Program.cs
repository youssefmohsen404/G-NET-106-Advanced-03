namespace G_NET_106_Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager

            /*List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            Helper.PrintCollection<int>("numbers", grades);
            Console.WriteLine("collection count ");
            Console.WriteLine(grades.Count());
            Console.WriteLine($"First grade : {grades.First() }");
            Console.WriteLine($"Last grade : {grades.Last() }");
            grades.Sort();
            Helper.PrintCollection("sorted grades", grades);
            Console.WriteLine();
            Console.WriteLine($"first grade above 90 :{ grades.Find(grade => grade > 90)}");
            Console.WriteLine("");
            Helper.PrintCollection("failing grades", grades.FindAll(grade => grade < 75));
            Console.WriteLine();
            grades.RemoveAll(grade => grade < 75);
            var is100 =  grades.Contains(100);
            Console.WriteLine(is100);
            
            List<string> strings = grades.Select(grade => $"grade:{grade}").ToList();
            Helper.PrintCollection("strings", strings);*/


            #endregion
            #region Exercise 2: Leaderboard

          /*  SortedDictionary<int, string> leaderBoard = new SortedDictionary<int, string>()
            {
                {500 ,"ahmed" },
                {200,"sara" },
                {800,"ali" },
                {350,"mona" },
            };
            Helper.PrintCollection("sorted leader board" , leaderBoard );
            Console.WriteLine();
            Console.WriteLine($"first value {leaderBoard.First()}");
            bool is500 = leaderBoard.ContainsKey(500);
            Console.WriteLine();
            Console.WriteLine("is there 500 ");
            Console.WriteLine(is500);
            var is999 = leaderBoard.TryGetValue(999 , out string leaderBoardString);
            Console.WriteLine("999 :");
            Console.WriteLine(is999);
            Console.WriteLine();
            leaderBoard.Remove(200);
            Helper.PrintCollection("updated leader board", leaderBoard);*/

            #endregion
        }
    }
}
