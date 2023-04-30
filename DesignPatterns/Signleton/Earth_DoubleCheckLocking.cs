namespace DesignPatterns
{
    public sealed class Earth_DoubleCheckLocking
    {
        public decimal Radius { get; set; }
        public decimal Weight { get; set; }


        public static void SetRadius(decimal radius)
        {
            Instance.Radius = radius;
        }
        public static void SetWeight(decimal weight)
        {
            Instance.Weight = weight;
        }

        private static Earth_DoubleCheckLocking _instance;
        private readonly static object _lockObject = new object();

        private Earth_DoubleCheckLocking() { }
        public static Earth_DoubleCheckLocking Instance { 
            get 
            {
                //For performance issue. Not lock evry thread while access to object
                if (_instance == null)
                {
                    lock (_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new Earth_DoubleCheckLocking();
                        }
                    }
                }
                return _instance;
            }
        }
        public override string ToString()
        {
            return $"Weight:{Instance.Weight}, Radius:{Instance.Radius}";
        }

    }
}
