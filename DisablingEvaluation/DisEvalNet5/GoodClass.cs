namespace DisEvalNet5
{
    public class GoodClass: ParentGoodClass,IGoodInterface
    {
        public string NormalProperty { get; set; } = "Normal value";
        string IGoodInterface.NormalProperty { get; set; } = "Interface Normal value";
        private int privateProperty { get; set; } = 1;
        public string NullProperty { get; set; }
        public bool BoolProperty { get; set; } = Truth();
        public static int StaticProperty => 1;
        public int Field = 1;
        
        public override string ToString()
        {
            return "Overridden Good Class";
        }
        
        private static bool Truth()
        {
            return true;
        }
    }

    public class ParentGoodClass
    {
        public string NormalProperty { get; set; } = "Parent normal value";
    }

    public interface IGoodInterface
    {
        public string NormalProperty { get; set; }
    }
    
    public struct GoodStruct
    {
        public GoodStruct(double x, double y)
        {
            X = x;
            Y = y;
            NormalProperty = "Struct Normal Property";
        }

        public double X { get; }
        public double Y { get; }
        public string NormalProperty { get; set; }

        public override string ToString() => $"({X}, {Y})";
    }
}