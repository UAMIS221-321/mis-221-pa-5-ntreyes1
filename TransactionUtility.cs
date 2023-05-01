namespace mis_221_pa_5_ntreyes1
{
    public class TransactionUtility
    {
        public void HistoricalRevenueReport() {
                    string[] lines = File.ReadAllLines("transactions.txt");

        Dictionary<string, double> revenueByMonth = new Dictionary<string, double>();
        Dictionary<string, double> revenueByYear = new Dictionary<string, double>();
        foreach (string line in lines) {
            string[] parts = line.Split('#');
            if (parts.Length >= 6) {
                string revenueStr = parts[5];
                double revenue;
                if (double.TryParse(revenueStr, out revenue)) {
                    DateTime date;
                    if (DateTime.TryParse(parts[3], out date)) {
                        string monthYear = date.ToString("MM/yyyy");
                        string year = date.Year.ToString();
                        if (revenueByMonth.ContainsKey(monthYear)) {
                            revenueByMonth[monthYear] += revenue;
                        }
                        else {
                            revenueByMonth[monthYear] = revenue;
                        }

                        if (revenueByYear.ContainsKey(year)) {
                            revenueByYear[year] += revenue;
                        }
                        else {
                            revenueByYear[year] = revenue;
                        }
                    }
                }
            }
        }

        foreach (string monthYear in revenueByMonth.Keys) {
            Console.WriteLine("{0}: {1}", monthYear, revenueByMonth[monthYear]);
        }

        foreach (string year in revenueByYear.Keys) {
            Console.WriteLine("{0}: {1}", year, revenueByYear[year]);
        }
        }
        // public void Sort() {
        //     for (int i = 0; i < Booking.GetCount() - 1; i++) {
        //         int min = i;
        //         for(int j = i + 1; j < Booking.GetCount(); j++) {
        //             if (bookings[j].GetCustomerName().CompareTo(bookings[min].GetCustomerName()) < 0 || (bookings[j].GetCustomerName() == bookings[min].GetCustomerName() && DateTime.Compare(bookings[j].GetDate(), bookings[min].GetDate()) < 0)) {
        //                 min = j;
        //             }
        //         }
        //         if (min != i) {
        //             Swap(min, i);
        //         }
        //     }
        // }   

        // private void Swap(int x, int y) {
        //     Booking temp = bookings[x];
        //     bookings[x] = bookings[y];
        //     bookings[y] = temp;
        // }
        // public void HistoricalCustomerSessionsReport() {
                
        //     List<TransactionUtility> transactions = ReadTransactionsFromFile();
                
        //     var customerGroups = transactions
        //             .GroupBy(t => t.customerName)
        //             .ToList();
                
        //     customerGroups.Sort((a, b) => a.Key.CompareTo(b.Key));
                
        //     Console.WriteLine("Historical customer sessions report:");
        //     foreach (var group in customerGroups) {
        //         Console.WriteLine("Customer Name: " + group.Key + ", Total Sessions: " + group.Count());
        //         foreach (Transaction t in group.OrderBy(t => t.TrainingDate)) {
        //                 Console.WriteLine("Session ID: " + t.SessionId + ", Training Date: " + t.TrainingDate.ToShortDateString() + ", Trainer Name: " + t.TrainerName);
        //             }
        //         }
        //         SaveReportToFile("HistoricalCustomerSessions.txt", transactions);
        //     }
        
    }
}   
