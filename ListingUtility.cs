namespace mis_221_pa_5_ntreyes1
{
    public class ListingUtility
    {
            private const string ListingsFileName = "listings.txt";
            private Listing[] listings;

            public ListingUtility(Listing[] listings)
            {
                this.listings = listings;
            }

            public void AddListingToFile(Listing listings)
            {
                using (StreamWriter writer = new StreamWriter(ListingsFileName, true))
                {
                    writer.WriteLine(listings.ToFile());
                }
            }

        public void GetAllListingsFromFile()
        {
            StreamReader inFile = new StreamReader("listings.txt");

            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                listings[Listing.GetCount()] = new Listing(temp[1], temp[2], int.Parse(temp[0]), DateOnly.Parse(temp[3]), TimeOnly.Parse(temp[4]), int.Parse(temp[5]));
                Listing.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
        }
        public void EditListing(int listingId, Listing editedListing) {
            string [] lines = File.ReadAllLines("listings.txt");
            bool listingFound = false;

            StreamWriter writer = new StreamWriter("listings.txt");

            foreach (string line in lines) {
                string[] data = line.Split('#');
                if (int.Parse(data[0]) == listingId) {
                    writer.WriteLine($"{editedListing.GetListingID()}#{editedListing.GetName()}#{editedListing.GetStatus()}#{editedListing.GetDate()}#{editedListing.GetTime()}#{editedListing.GetCost()}");
                    listingFound = true;
                }
                else {
                    writer.WriteLine(line);
                }
            }
            writer.Close();
        }
        public void DeleteListing(int listingId) {
            string [] lines = File.ReadAllLines("listings.txt");
            bool listingFound = false;

            StreamWriter writer = new StreamWriter("listings.txt");

            foreach (string line in lines) {
                string[] data = line.Split('#');
                if (int.Parse(data[0]) == listingId) {
                    listingFound = true;
                }
                else {
                    writer.WriteLine(line);
                }
            }
            writer.Close();
        }
    }
}

