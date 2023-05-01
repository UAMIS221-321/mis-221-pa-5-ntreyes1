using System;
namespace mis_221_pa_5_ntreyes1
{
    public class BookingUtility
    {
            private const string BookingsFileName = "transactions.txt";
            private Booking[] bookings;

            public BookingUtility(Booking[] bookings)
            {
                this.bookings = bookings;
            }

            public void AddBookingToFile(Booking bookings)
            {
                using (StreamWriter writer = new StreamWriter(BookingsFileName, true))
                {
                    writer.WriteLine(bookings.ToFile());
                }
            }
        //     public void Sort() {
        //     for (int i = 0; i < Booking.GetCount() - 1; i++) {
        //         int min = i;
        //         for(int j = i + 1; j < Booking.GetCount(); j++) {
        //             if (bookings[j].GetCustomerName().CompareTo(bookings[min].GetCustomerName()) < 0 || (bookings[j].GetCustomerName() == bookings[min].GetCustomerName() && DateOnly.Compare(bookings[j].GetDate(), bookings[min].GetDate()) < 0)) {
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

    //     public void GetAllBookingsFromFile()
    //     {
    //         StreamReader inFile = new StreamReader("transactions.txt");

    //         Listing.SetCount(0);
    //         string line = inFile.ReadLine();
    //         while (line != null)
    //         {
    //             string[] temp = line.Split("#");
    //             bookings[Booking.GetCount()] = new Booking(temp[1], DateOnly.Parse(temp[3]), int.Parse(temp[0]), temp[5], int.Parse(temp[4]), temp[2], temp[6]);
    //             Booking.IncCount();
    //             line = inFile.ReadLine();
    //         }

    //         inFile.Close();
    //     }
    //     public void HistoricalCustomerSessions() {
    //         string[] lines = File.ReadAllLines("transactions.txt");

    //         // Parse the transactions and group them by customer
    //         var customerSessions = new Dictionary<string, List<Transaction>>();
    //         foreach (string line in lines) {
    //             string[] values = line.Split('#');
    //             if (values.Length >= 3) {
    //                 string customer = values[1];
    //             DateOnly date = Booking.GetDate(values[2]);
    //             decimal cost = decimal.Parse(values[3]);
    //             Transaction transaction = new Transaction(customer, date, cost);
    //             if (!customerSessions.ContainsKey(customer)) {
    //                 customerSessions[customer] = new List<Transaction>();
    //             }
    //         customerSessions[customer].Add(transaction);
    //         }
    //     }

    //     // Sort the transactions by customer and then by date
    //     foreach (var sessions in customerSessions.Values) {
    //         sessions.Sort((t1, t2) => {
    //             int result = t1.Customer.CompareTo(t2.Customer);
    //             if (result == 0) {
    //                 result = t1.Date.CompareTo(t2.Date);
    //             }
    //             return result;
    //         });
    //     }

    //     // Display the results
    //     foreach (var entry in customerSessions) {
    //         string customer = entry.Key;
    //         List<Transaction> sessions = entry.Value;
    //         int totalSessions = sessions.Count;
    //         decimal totalCost = sessions.Sum(t => t.Cost);
    //         Console.WriteLine($"Customer: {customer}, Total Sessions: {totalSessions}, Total Cost: {totalCost}");
    //         foreach (Transaction transaction in sessions) {
    //             Console.WriteLine($"{transaction.Date.ToShortDateString()} - ${transaction.Cost}");
    //         }
    //         Console.WriteLine();
    //     }
    // }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public void HistoricalCustomerSessions() {
        //     string[] lines = File.ReadAllLines("transactions.txt");
        //     string selectedTransaction = null;
        //     for (int i = 0; i < lines.Length; i++) {
        //         string line = lines[i];
        //         string[] values = line.Split('#');
        //         if (values.Length > 0 && values[0] == cost) {
        //             values[2] = "Booked";
        //             totalCost = string.Join("#", values);
        //             lines[i] = string.Join("#", values);
        //             break;
        //         }
        //     }
        // }
    }
}