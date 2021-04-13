namespace SmartEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Card type: {CardType.Amex}, id: {CardType.Amex.Id}, hashcode: {CardType.Amex.GetHashCode()}");
            System.Console.WriteLine($"Card type: {CardType.MasterCard}, id: {CardType.MasterCard.Id}, hashcode: {CardType.MasterCard.GetHashCode()}");
            System.Console.WriteLine($"Card type: {CardType.Visa}, id: {CardType.Visa.Id}, hashcode: {CardType.Visa.GetHashCode()}");

            var c1 = CardType.Amex;
            var c2 = CardType.MasterCard;
            var c3 = CardType.Visa;

            System.Console.WriteLine($"{c1} compared to {c1}: {c1.Equals(c1)}");
            System.Console.WriteLine($"{c1} compared to {c2}: {c1.Equals(c2)}");
            System.Console.WriteLine($"{c1} compared to {c3}: {c1.Equals(c3)}");
            System.Console.WriteLine($"{c2} compared to {c2}: {c2.Equals(c2)}");
            System.Console.WriteLine($"{c2} compared to {c3}: {c2.Equals(c3)}");
            System.Console.WriteLine($"{c3} compared to {c3}: {c3.Equals(c3)}");
        }
    }
}
