namespace mis_221_pa_5_ntreyes1
{
    public class TrainerUtility
    {
            private const string TrainersFileName = "trainers.txt";
            private Trainer[] trainers;

            public TrainerUtility(Trainer[] trainers)
            {
                this.trainers = trainers;
            }

            public void AddTrainerToFile(Trainer trainer)
            {
                using (StreamWriter writer = new StreamWriter(TrainersFileName, true))
                {
                    writer.WriteLine(trainer.ToFile());
                }
            }

        public void GetAllTrainersFromFile()
        {
            StreamReader inFile = new StreamReader("trainers.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                trainers[Trainer.GetCount()] = new Trainer(temp[1], temp[2], int.Parse(temp[0]), temp[3]);
                Trainer.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
        }

        public void EditTrainer(int trainerId, Trainer editedTrainer) {
            string [] lines = File.ReadAllLines("trainers.txt");
            bool trainerFound = false;

            StreamWriter writer = new StreamWriter("trainers.txt");

            foreach (string line in lines) {
                string[] data = line.Split('#');
                if (int.Parse(data[0]) == trainerId) {
                    writer.WriteLine($"{editedTrainer.GetTrainerID()}#{editedTrainer.GetName()}#{editedTrainer.GetAddress()}#{editedTrainer.GetEmail()}");
                    trainerFound = true;
                }
                else {
                    writer.WriteLine(line);
                }
            }
            writer.Close();
        }

        public void DeleteTrainer(int trainerId) {
            string [] lines = File.ReadAllLines("trainers.txt");
            bool trainerFound = false;

            StreamWriter writer = new StreamWriter("trainers.txt");

            foreach (string line in lines) {
                string[] data = line.Split('#');
                if (int.Parse(data[0]) == trainerId) {
                    trainerFound = true;
                }
                else {
                    writer.WriteLine(line);
                }
            }
            writer.Close();
        }
    }
}

