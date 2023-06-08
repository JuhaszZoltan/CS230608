namespace UtasszallitokCLI
{
    class Sebessegkategoria
    {
        public static readonly string[] sebkatnevek = {
            "Alacsony sebességű",
            "Szubszonikus",
            "Transzszonikus",
            "Szuperszonikus",
        };

        private readonly int utazosebesseg;

        public string Kategorianev => utazosebesseg switch
        {
            < 500 => "Alacsony sebességű",
            < 1000 => "Szubszonikus",
            < 1200 => "Transzszonikus",
            _ => "Szuperszonikus",
        };

        public Sebessegkategoria(int utazosebesseg)
        {
            this.utazosebesseg = utazosebesseg;
        }
    }
}
