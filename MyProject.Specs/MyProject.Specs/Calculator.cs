namespace MyProject.Specs
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; internal set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}