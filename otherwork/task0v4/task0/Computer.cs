namespace task0
{
    public class Computer : Item
    {
        public Computer(int count, int date, IDiscount discount)
            : base("NoteBook", count, date, discount){}

        public Computer(int count, int date)
            : base("NoteBook", count, date){}
    }
}