namespace DesignPatterns
{
    //As you can see, this is really is extremely simple - but why is it thread-safe and how lazy is it?
    //Well, static constructors in C# are specified to execute only when an instance of the class is created or a static member is referenced, and to execute only once per AppDomain.
    public sealed class Earth_StaticBuNotLazy
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
        private static Earth_StaticBuNotLazy _instance = new Earth_StaticBuNotLazy();

        private Earth_StaticBuNotLazy() { }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Earth_StaticBuNotLazy() { }

        public static Earth_StaticBuNotLazy Instance {
            get
            {
                return _instance;
            }
        }
        public override string ToString()
        {
            return $"Weight:{Instance.Weight}, Radius:{Instance.Radius}";
        }
    }
}
