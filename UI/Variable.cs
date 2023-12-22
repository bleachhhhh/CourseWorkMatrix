
namespace UI
{
    internal class Variable
    {
        private string _name;

        private double _value;

        private double _coeff;

        public string Name { get => _name; set => _name = value; }
        public double Value { get => _value; set => _value = value; }
        public double Coeff { get => _coeff; set => _coeff = value; }

        public Variable(string name, double coeff)
        {
            Name = name;
            Coeff = coeff;
        }
    }
}
