namespace mis_221_pa_5_ntreyes1
{
    public class Trainer
    {
        private string name;
        private string address;
        private int trainerid;
        static public int count;

        private string email;

        // constructor
        public Trainer(int trainerId, string? name) {

        }
        public Trainer(string name, string address, int trainerid, string email) {
            this.name = name;
            this.address = address;
            this.trainerid = trainerid;
            this.email = email;
        }


        public void SetEmail(string email) {
            this.email = email;
        }
        public string GetEmail() {
            return email;
        }
        public void SetName(string name) {
            this.name = name;
        }
        public string GetName() {
            return name;
        }
        public void SetAddress(string address) {
            this.address = address;
        }
        public string GetAddress() {
            return address;
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
            Trainer.count++;
        }
        public static int GetCount() {
            return count;
        }

        public override string ToString()
        {
            return $"{this.name} was written by {this.address} and has {this.trainerid} pages and the genre is {this.email}";
        }

        public string ToFile() {
            return $"{trainerid}#{name}#{address}#{email}";
        }
    }
}