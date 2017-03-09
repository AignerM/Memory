namespace Memory
{
    public class Highscore
    {

        public Highscore(string name, int time, int trys)
        {
            this.HName = name;
            this.HTime = time;
            this.HTrys = trys;
        }

        public int HTime { get; set; }

        public int HTrys { get; set; }

        public string HName { get; set; }
    }
}
