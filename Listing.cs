namespace mis_221_pa_5_ntreyes1
{
    public class Listing
    {
        private string name;
        private string status;
        private int listingid;
        private TimeOnly time;
        private int cost;
        static public int count;

        private DateOnly date;

        // constructor
        public Listing() {

        }
        public Listing(string name, string status, int listingid, DateOnly date, TimeOnly time, int cost) {
            this.name = name;
            this.status = status;
            this.listingid = listingid;
            this.date = date;
            this.time = time;
            this.cost = cost;
        }


        public void SetCost(int cost) {
            this.cost = cost;
        }
        public int GetCost() {
            return cost;
        }
        public void SetTime(TimeOnly time) {
            this.time = time;
        }
        public TimeOnly GetTime() {
            return time;
        }
        public void SetDate(DateOnly date) {
            this.date = date;
        }
        public DateOnly GetDate() {
            return date;
        }
        public void SetName(string name) {
            this.name = name;
        }
        public string GetName() {
            return name;
        }
        public void SetStatus(string status) {
            this.status = status;
        }
        public string GetStatus() {
            return status;
        }
        public void SetListingID(int listingid) {
            this.listingid = listingid;
        }
        public int GetListingID() {
            return listingid;
        }

        public static int SetCount(int count) {
            return count;
        }
        public static void IncCount() {
            Listing.count++;
        }
        public static int GetCount() {
            return count;
        }

        public override string ToString()
        {
            return $"Session ID: {this.listingid} Trainer Name: {this.name} Status: {this.status} Date: {this.date} Time: {this.time} Cost: ${this.cost}";
        }

        public string ToFile() {
            return $"{listingid}#{name}#{status}#{date}#{time}#{cost}";
        }
    }
}