
namespace mis_221_pa_5_ntreyes1
{
    public class Booking

    {
        private string customerName;
        private DateOnly date;
        private int listingid;
        private string name;
        private int trainerid;
        static public int count;

        private string email;
        private string status;

        // constructor
        public Booking() {

        }
        public Booking(string customerName, DateOnly date, int listingid, string name, int trainerid, string email, string status) {
            this.customerName = customerName;
            this.date = date;
            this.listingid = listingid;
            this.name = name;
            this.trainerid = trainerid;
            this.email = email;
            this.status = status;
        }

        public void SetCustomerName(string customerName) {
            this.customerName = customerName;
        }
        public string GetCustomerName() {
            return customerName;
        }
        public void SetStatus(string status) {
            this.status = status;
        }
        public string GetStatus(string status) {
            return status;
        }
        public void SetDate(DateOnly date) {
            this.date = date;
        }
        public DateOnly GetDate() {
            return date;
        }
        public void SetListingID(int listingid) {
            this.listingid = listingid;
        }
        public int GetListingID(int listingid) {
            return listingid;
        }
        public void SetEmail(string email) {
            this.email = email;
        }
        public string GetEmail(string email) {
            return email;
        }
        public void SetName(string name) {
            this.name = name;
        }
        public string GetName(string name) {
            return name;
        }
        public void SetTrainerID(int trainerid) {
            this.trainerid = trainerid;
        }
        public int GetTrainerID() {
            return trainerid;
        }

        public static int SetCount(int count) {
            return count;
        }
        public static void IncCount() {
            Booking.count++;
        }
        public static int GetCount() {
            return count;
        }

        public override string ToString()
        {
            return $"Listing ID: {listingid} Customer Name: {customerName} Customer Email: {email} Date: {date} Trainer ID: {trainerid} Trainer Name: {name} Status {status}";
        }

        public string ToFile() {
            return $"{listingid}#{customerName}#{email}#{date}#{trainerid}#{name}#{status}";
        }
    }
}