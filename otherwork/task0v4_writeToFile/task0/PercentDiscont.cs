namespace task0
{
    class PercentDiscont : IDiscount
    {
        private const int Percent = 15;
        public double SetPrice(double price, int count)
        {
            return price * count * (1 - Percent / 100d);
        }
        public override string ToString()
        {
            return string.Format("\t{0}%", Percent);
        }
    }
}