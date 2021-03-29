namespace SmartEnum
{
    /// <summary>
    /// Based on https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
    /// </summary>
    public class CardType : Enumeration
    {
        public static CardType Amex = new CardType(1, nameof(Amex));
        public static CardType Visa = new CardType(2, nameof(Visa));
        public static CardType MasterCard = new CardType(3, nameof(MasterCard));

        public CardType(int id, string name) : base(id, name)
        {
        }
    }
}
