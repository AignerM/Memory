namespace Memory
{
    public class Player
    {

        public int Time { get; set; }
        
        public string Name { get; set; }

        public int Trys { get; set; }

        public Player(string name, int time, int trys)
        {
            this.Time = time;
            this.Trys = trys;
            this.Name = name;
        }
    }
}
