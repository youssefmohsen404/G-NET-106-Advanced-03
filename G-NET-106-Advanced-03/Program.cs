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
            #region Exercise 3: Phone Book
            /* Dictionary<string, string> phoneBook = new Dictionary<string, string>
             {
                 { "Ahmed"  ,"010025646" },
                 { "youssef"  ,"010025647" },
                 { "mohamed"  ,"010025648" },
                 { "fares"  ,"010025649" },

             };
             phoneBook["yassin"] = "0102154815";
             Helper.PrintCollection("phone book" , phoneBook );
             Console.WriteLine();

             try
             {
                 phoneBook.Add("Ahmed", "010025646");
             }
             catch (Exception ex) {
                 Console.WriteLine($"error : {ex.Message}");
             }
             Console.WriteLine();
             Console.WriteLine("is duplicte added:");

            bool isAdded =  phoneBook.TryAdd("Ahmed", "010025646");
             Console.WriteLine(isAdded);

             bool isThere = phoneBook.ContainsKey("mariam");
             Console.WriteLine();
             Console.WriteLine($"is this contact there: {isThere}");
             string search = phoneBook.GetValueOrDefault("yasser" , "not found");
             Console.WriteLine(search);

             Console.WriteLine();
             Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
             Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));*/
            #endregion
            #region Exercise 4: Unique Email Validator

            /*     HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                 {
                 };
                 Console.WriteLine($"Add ahmed@test.com: {emails.Add("ahmed@test.com")}");
                 Console.WriteLine($"Add AHMED@test.com: {emails.Add("AHMED@test.com")}");
                 Console.WriteLine($"Add sara@test.com:  {emails.Add("sara@test.com")}");
                 Console.WriteLine($"Add Sara@Test.Com:  {emails.Add("Sara@Test.Com")}");
                 Helper.PrintCollection("emails" , emails );
                 int count =  emails.Count();
                 Console.WriteLine($"count :{count}");
                 // count equals 2 because there is no duplications in hash sets and w created a case sensitive hashset
                 // so ahmed is like AHMED so it is a duplicated item

                 HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
                 HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

                 HashSet<int> union = new HashSet<int>(setA);
                 union.UnionWith(setB);
                 Helper.PrintCollection("union" , union );


                 HashSet<int> intersect = new HashSet<int>(setA);
                 intersect.IntersectWith(setB);
                 Helper.PrintCollection("intersect" , intersect );


                 HashSet<int> except = new HashSet<int>(setA);
                 except.ExceptWith(setB);
                 Helper.PrintCollection("except" ,  except );

                 HashSet<int> small = new HashSet<int> { 1, 2 };
                 Console.WriteLine($"{{1,2}} is a subset of A: {small.IsSubsetOf(setA)}");*/
            #endregion
            #region Exercise 5: Print Queue Simulator
            //fifo
           /* Queue<string> document = new Queue<string>();
            document.Enqueue("Report.pdf");
            document.Enqueue("Invoice.pdf");
            document.Enqueue("Letter.docx");
            document.Enqueue("Resume.pdf");
            document.Enqueue("Photo.jpg");

            Helper.PrintCollection("documents" , document);
            Console.WriteLine("count");
             Console.WriteLine(document.Count());
            Console.WriteLine("first printed document");
            Console.WriteLine(document.Peek());
            Console.WriteLine();
            Console.WriteLine($"Printing : {document.Dequeue()}");
            Console.WriteLine($"Printing : {document.Dequeue()}");
            Console.WriteLine($"Printing : {document.Dequeue()}");
            Console.WriteLine($"Printing : {document.Dequeue()}");
            Console.WriteLine($"Printing : {document.Dequeue()}");
            bool isDequeued = document.TryDequeue(out string dequeItem);
            Console.WriteLine(isDequeued);*/
            #endregion
        }
    }
}
