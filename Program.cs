using mis_221_pa_5_ntreyes1;

// start main
int userChoice = GetUserChoice();
// pretest loop
while(userChoice!=6) { // condition check
   RouteEm(userChoice); 
  userChoice = GetUserChoice();
 }

// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

// *** Main Menu ***
static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("1.    Manage Trainer Data"); 
    System.Console.WriteLine("2.    Manage Listing Data");
    System.Console.WriteLine("3.    Manage Customer Booking Data"); 
    System.Console.WriteLine("4.    Run Reports");
    System.Console.WriteLine("5.    Session Feedback");
    System.Console.WriteLine("6.    Exit");

}

static bool IsValidChoice(string userInput) {
    if(userInput =="1" || userInput =="2" || userInput=="3" || userInput=="4" || userInput=="5" || userInput=="6") {
        return true;
    }
    return false;
}

// *** Manage Trainer Data ***
static void DisplayTrainerData() {
    Console.Clear();
    System.Console.WriteLine("* Trainer Data Management *");
    System.Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("1.    Add a trainer.");
    System.Console.WriteLine("2.    Edit a trainer.");
    System.Console.WriteLine("3.    Delete a trainer.");
    int input = int.Parse(Console.ReadLine());
    if (input == 1) {
    {
        Console.Clear();
        System.Console.WriteLine("*Add a Trainer*");
        Trainer[] trainers = new Trainer[50];
        TrainerUtility utility = new TrainerUtility(trainers);

        utility.GetAllTrainersFromFile();

        Console.WriteLine("Enter the trainer's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the trainer's mailing address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter the trainer's email address:");
        string email = Console.ReadLine();

        int trainerId = Trainer.GetCount() + 1;

        Trainer newTrainer = new Trainer(name, address, trainerId, email);
        utility.AddTrainerToFile(newTrainer);

        Console.WriteLine("Trainer added successfully.");
    }
    
    }
    else if (input == 2) {
        Console.Clear();
        System.Console.WriteLine("*Edit a Trainer*");
        System.Console.WriteLine("Enter the Trainer ID you wish to edit:");
        int trainerId = int.Parse(Console.ReadLine());

        Trainer[] trainers = new Trainer[50];
        TrainerUtility utility = new TrainerUtility(trainers);

        System.Console.WriteLine("Please enter the new name:");
        string newName = Console.ReadLine();

        System.Console.WriteLine("Please enter the new mailing address:");
        string newAddress = Console.ReadLine();

        System.Console.WriteLine("Please enter the new email address:");
        string newEmail = Console.ReadLine();

        Trainer editedTrainer = new Trainer(newName, newAddress, trainerId, newEmail);
        utility.EditTrainer(trainerId, editedTrainer);


        Console.WriteLine("Trainer Edited successfully!");

    }

    else if (input == 3) {
        Console.Clear();
        System.Console.WriteLine("*Delete a Trainer*");
        System.Console.WriteLine("Enter the Trainer ID you wish the delete:");
        int trainerId = int.Parse(Console.ReadLine());
        //utility.DeleteTrainer(trainerId);
        Trainer[] trainers = new Trainer[50];
        TrainerUtility utility = new TrainerUtility(trainers);
        utility.DeleteTrainer(trainerId);
        System.Console.WriteLine("Trainer Deleted Successfully!");

    }
    PauseAction();
}

// *** Manage Listing Data ***
static void DisplayListingData() {
    Console.Clear();
    System.Console.WriteLine("* Listing Data Management *");
    System.Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("1.    Add a listing.");
    System.Console.WriteLine("2.    Edit a listing.");
    System.Console.WriteLine("3.    Delete a listing.");
    int input = int.Parse(Console.ReadLine());
    if (input == 1) {
        Console.Clear();
        System.Console.WriteLine("*Add a Listing*");
        Listing[] listings = new Listing[50];
        ListingUtility utility = new ListingUtility(listings);

        utility.GetAllListingsFromFile();

        Console.WriteLine("Enter the name of the trainer:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the status of the listing:");
        string status = Console.ReadLine();

        Console.WriteLine("Enter the date of the session (Ex: MM/DD/YYYY):");
        string date = (Console.ReadLine());

        System.Console.WriteLine("Enter the time of the session (Ex: HH:MM AM/PM):");
        TimeOnly time = TimeOnly.Parse(Console.ReadLine());

        System.Console.Write("Enter the cost of the session: $");
        int cost = int.Parse(Console.ReadLine());

        int listingId = Listing.GetCount() + 1;

        Listing newListing = new Listing(name, status, listingId, DateOnly.Parse(date), time, cost);
        utility.AddListingToFile(newListing);

        Console.Clear();

        Console.WriteLine("Listing added successfully!");

    }

    if (input == 2) {
        Console.Clear();
        System.Console.WriteLine("*Edit a Listing*");
        System.Console.WriteLine("Enter the Listing ID you wish to edit:");
        int listingId = int.Parse(Console.ReadLine());

        Listing[] listings = new Listing[50];
        ListingUtility utility = new ListingUtility(listings);

        System.Console.WriteLine("Please enter the new name of the trainer:");
        string newName = Console.ReadLine();

        System.Console.WriteLine("Please enter the new status of the listing:");
        string newStatus = Console.ReadLine();

        System.Console.WriteLine("Please enter the new date of the session (Ex: MM/DD/YYYY):");
        string newDate = Console.ReadLine();

        System.Console.WriteLine("Please enter the new time of the session (Ex: HH:MM AM/PM):");
        TimeOnly newTime = TimeOnly.Parse(Console.ReadLine());

        System.Console.WriteLine("Please enter the new cost of the session:");
        int newCost = int.Parse(Console.ReadLine());

        Listing editedListing = new Listing(newName, newStatus, listingId, DateOnly.Parse(newDate), newTime, newCost);
        utility.EditListing(listingId, editedListing);


        Console.WriteLine("Listing Edited successfully!");
        
    }

    else if (input == 3) {
        Console.Clear();
        System.Console.WriteLine("*Delete a Listing*");
        System.Console.WriteLine("Enter the Listing ID you wish the delete:");
        int listingId = int.Parse(Console.ReadLine());
        //utility.DeleteTrainer(trainerId);
        Listing[] listings = new Listing[50];
        ListingUtility utility = new ListingUtility(listings);
        utility.DeleteListing(listingId);
        System.Console.WriteLine("Listing Deleted Successfully!");
    }
    PauseAction();
}

// *** Manage Customer Booking Data ***
//1#Nick Reyes#Available#5/4/2023#3:30 PM#50
static void DisplayBookingData() {
    Listing[] listings = new Listing[50];
    ListingUtility utility = new ListingUtility(listings);
    ListingReport report = new ListingReport(listings);
    Console.Clear();
    System.Console.WriteLine("Training Sessions");
    System.Console.WriteLine("_________________");
    utility.GetAllListingsFromFile();
    report.PrintAllListings();
        System.Console.WriteLine("_________________");
        System.Console.WriteLine("*Session Booking*");
        System.Console.WriteLine("Please enter the Session ID you wish to book.");
        string listingId = Console.ReadLine();
        string[] lines = File.ReadAllLines("listings.txt");

        string selectedListing = null;
        for (int i = 0; i < lines.Length; i++) {
            string line = lines[i];
            string[] values = line.Split('#');
            if (values.Length > 0 && values[0] == listingId) {
                values[2] = "Booked";
                selectedListing = string.Join("#", values);
                lines[i] = string.Join("#", values);
                break;
            }
        }

        if (selectedListing != null) {
            Console.Clear();
            Console.WriteLine(selectedListing);
            System.Console.WriteLine("______________________");
            System.Console.WriteLine("Are you sure you want to book this session?");
            System.Console.WriteLine("1.    Yes");
            System.Console.WriteLine("2.    No");
            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 1) {
                //Listing[] listings = new Listing[50];
                //ListingUtility utility = new ListingUtility(listings);
                utility.DeleteListing(int.Parse(listingId));
                System.Console.WriteLine("Please enter your full name:");
                string customerName = Console.ReadLine();

                System.Console.WriteLine("Please enter your email:");
                string email = Console.ReadLine();

                string transaction = selectedListing + "#" + customerName + "#" + email;

                using (StreamWriter sw = File.AppendText("Transactions.txt")) {
                    sw.WriteLine(transaction);
                }
                System.Console.WriteLine("Session Booked Successfully!");
                PauseAction();
            }
        } else {
            System.Console.WriteLine("Invalid Session ID. Please try again.");
            PauseAction();
        }
    }

// *** Run Reports ***
static void DisplayRunReports()
{
    Console.Clear();
    System.Console.WriteLine("*Reports*");
    System.Console.WriteLine("View reports by:");
    System.Console.WriteLine("1.    Individual Customer Sessions");
    System.Console.WriteLine("2.    Historical Customer Sessions");
    System.Console.WriteLine("3.    Historical Revenue Report");
    int input = int.Parse(Console.ReadLine());
    if (input == 1)
    {
        Console.Clear();
        System.Console.WriteLine("*Individual Customer Reports*");
        System.Console.WriteLine("Please enter customer email:");
        string customerEmail = Console.ReadLine();
        string[] lines = File.ReadAllLines("Transactions.txt");
        var matchingLines = lines.Where(line => line.Contains(customerEmail));
        if (matchingLines.Any()) {
            foreach (string matchingLine in matchingLines) {
                Console.WriteLine(matchingLine);
            }
            System.Console.WriteLine("Would you like to save this report to a file?");
            System.Console.WriteLine("1.    Yes");
            System.Console.WriteLine("2.    No");
            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 1) {
                System.Console.WriteLine("What would you like to name the file?");
                string newReportFile = Console.ReadLine();
                File.WriteAllLines(newReportFile, matchingLines);
                Console.Clear();
                System.Console.WriteLine("File saved to " + newReportFile);
                }
            else if (input2 == 2) {
            }
        }
        else {
            System.Console.WriteLine("Customer Email not found!");
        }
        PauseAction();
    }
    if (input == 2) {
        Transaction transaction = new Transaction();
        transaction.HistoricalCustomerSessionsReport();
        PauseAction();
    }
    else if (input == 3) {
        TransactionUtility transaction = new TransactionUtility();
        transaction.HistoricalRevenueReport();
        PauseAction();
    }
}

//EXTRA FeedBack Display
static void DisplayFeedBack() {
    Console.Clear();
    System.Console.WriteLine("*FeedBack*");
    System.Console.WriteLine("Please enter your email.");
    string customerEmail = Console.ReadLine();
        string[] lines = File.ReadAllLines("Transactions.txt");
        var matchingLines = lines.Where(line => line.Contains(customerEmail));
        if (matchingLines.Any()) {
            foreach (string matchingLine in matchingLines) {
                Console.WriteLine(matchingLine);
            }
        }
        System.Console.WriteLine("Please enter the listing ID you would like to provide feedback for.");
        string listingId = Console.ReadLine();
        string[] lines2 = File.ReadAllLines("transactions.txt");

        string selectedTransaction = null;
        for (int i = 0; i < lines.Length; i++) {
            string line = lines[i];
            string[] values = line.Split('#');
            if (values.Length > 0 && values[0] == listingId) {
                values[2] = "FEEDBACK";
                selectedTransaction = string.Join("#", values);
                lines[i] = string.Join("#", values);
                break;
            }
        }

        if (selectedTransaction != null) {
            Console.Clear();
            Console.WriteLine(selectedTransaction);
            System.Console.WriteLine("______________________");
            System.Console.WriteLine("Are you sure you want to review this session?");
            System.Console.WriteLine("1.    Yes");
            System.Console.WriteLine("2.    No");
            int input2 = int.Parse(Console.ReadLine());
            if (input2 == 1) {
                //Listing[] listings = new Listing[50];
                //ListingUtility utility = new ListingUtility(listings);
                System.Console.WriteLine("Please enter rating from 1 - 5");
                string customerRating = Console.ReadLine();

                System.Console.WriteLine("Please enter any other information:");
                string bio = Console.ReadLine();

                string feedback = selectedTransaction + "#" + customerRating + "#" + bio;

                using (StreamWriter sw = File.AppendText("feedback.txt")) {
                    sw.WriteLine(feedback);
                }
                System.Console.WriteLine("Session Reviewed Successfully!");
                PauseAction();
            }
        }


}
// Behind the scenes of routing users and returning them to main menu

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
}

static void RouteEm(int menuChoice) {
    if (menuChoice==1) {
        DisplayTrainerData();
    }
    else if (menuChoice==2) {
        DisplayListingData();
    }
    else if(menuChoice==3) {
        DisplayBookingData();   
    }
    else if(menuChoice==4) {
        DisplayRunReports();
    }
    else if(menuChoice==5) {
        DisplayFeedBack();
    }
    else if(menuChoice==6) {
        SayInvalid();
    }
    else {
        System.Console.WriteLine("Invalid. Please Try Again!");
        PauseAction();
    
    }

}

static void PauseAction() {
    System.Console.WriteLine("Press any key to return to main menu..."); //Key to return users to main menu
    Console.ReadKey();
}