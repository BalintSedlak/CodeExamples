namespace SmartEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Card type: {CardType.Amex}, id: {CardType.Amex.Id}, hashcode: {CardType.Amex.GetHashCode()}");
            System.Console.WriteLine($"Card type: {CardType.MasterCard}, id: {CardType.MasterCard.Id}, hashcode: {CardType.MasterCard.GetHashCode()}");
            System.Console.WriteLine($"Card type: {CardType.Visa}, id: {CardType.Visa.Id}, hashcode: {CardType.Visa.GetHashCode()}");
        }
    }
}
