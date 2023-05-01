namespace mis_221_pa_5_ntreyes1
{
    public class ListingReport
    {
        Listing[] listings;

        public ListingReport(Listing[] listings) {
            this.listings = listings;
        }
        public void PrintAllListings() {
            if (listings != null)
            for(int i = 0; i < Listing.GetCount(); i++) {
                System.Console.WriteLine(listings[i].ToString());
            }
            else {
                System.Console.WriteLine("We encountered an Error. Please try again!");
            }
        }
    }
}