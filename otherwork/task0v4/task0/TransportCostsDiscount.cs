namespace task0
{
    class TransportCostsDiscount:IDiscount
    {
        private const int transportCosts = 450000;
        public double SetPrice(double price, int count)
            {
                return price*count - transportCosts;
            }
            public override string ToString()
            {
                return string.Format("\t{0} BYR transport costs", transportCosts);
            }
    }
}