namespace mis_221_pa_5_ntreyes1
{
    public class Transaction
    {
        public string SessionId { get; set; }
        public DateTime TrainingDate { get; set; }
        public string TrainerName { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return $"Session ID: {SessionId}, Training Date: {TrainingDate.ToShortDateString()}, Trainer Name: {TrainerName}";
        }
        public static List<Transaction> ReadTransactionsFromFile()
        {
            List<Transaction> transactions = new List<Transaction>();
            StreamReader inFile = new StreamReader("transactions.txt");
            string line;
            while ((line = inFile.ReadLine()) != null)
            {
                string[] data = line.Split('#');
                transactions.Add(new Transaction {
                    SessionId = data[0].Trim(), TrainingDate = DateTime.Parse(data[3].Trim()), TrainerName = data[1].Trim(),CustomerName = data[6].Trim()});
            }
            inFile.Close();
            return transactions;
        }

        public void HistoricalCustomerSessionsReport()
        {
            List<Transaction> transactions = ReadTransactionsFromFile();

            var customerGroups = transactions.GroupBy(t => t.CustomerName).ToList();

            customerGroups.Sort((a, b) => a.Key.CompareTo(b.Key));

            Console.WriteLine("Historical customer sessions report:");
            foreach (var group in customerGroups)
            {
                Console.WriteLine("Customer Name: " + group.Key + ", Total Sessions: " + group.Count());
                foreach (Transaction t in group.OrderBy(t => t.TrainingDate))
                {
                    Console.WriteLine(t.ToString());
                }
            }
            // System.Console.WriteLine("Would you like to save this report to a file?");
            // System.Console.WriteLine("1.    Yes");
            // System.Console.WriteLine("2.    No");
            // int input2 = int.Parse(Console.ReadLine());
            // if (input2 == 1) {
            //     System.Console.WriteLine("What would you like to name the file?");
            //     string newReportFile = Console.ReadLine();
            //     File.WriteAllLines(newReportFile, report);
            //     Console.Clear();
            //     System.Console.WriteLine("File saved to " + newReportFile);
        //}
        }
    }
}