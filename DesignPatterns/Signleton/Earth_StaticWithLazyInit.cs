namespace DesignPatterns
{
    //Here, instantiation is triggered by the first reference to the static member of the nested class, which only occurs in Instance.
    //This means the implementation is fully lazy, but has all the performance benefits of the previous ones. 
    public sealed class Earth_StaticWithLazyInit
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
        private Earth_StaticWithLazyInit() { }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Earth_StaticWithLazyInit() { }

        public static Earth_StaticWithLazyInit Instance
        {
            get
            {
                return Earth_StaticWithLazyInit_Inner.Instance;
            }
        }
        public override string ToString()
        {
            return $"Weight:{Instance.Weight}, Radius:{Instance.Radius}";
        }

        private class Earth_StaticWithLazyInit_Inner
        {
            private static Earth_StaticWithLazyInit _instance = new Earth_StaticWithLazyInit();
            static Earth_StaticWithLazyInit_Inner() { }

            internal static Earth_StaticWithLazyInit Instance
            {
                get
                {
                    return _instance;
                }
            }

        }
    }
}
