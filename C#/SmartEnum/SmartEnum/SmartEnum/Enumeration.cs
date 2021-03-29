using System;
using System.Collections.Generic;

namespace SmartEnum
{
    /// <summary>
    /// Based on https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
    /// </summary>
    public abstract class Enumeration : IComparable, IEquatable<Enumeration>
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() 
        { 
            return Name; 
        }

        public override bool Equals(object obj)
        {
            if (obj is Enumeration otherValue)
            {
                var typeMatches = GetType().Equals(obj.GetType());
                var valueMatches = Id.Equals(otherValue.Id);

                return typeMatches && valueMatches;
            }

            return false;
        }

        public int CompareTo(object other)
        {
            return Id.CompareTo(((Enumeration)other).Id);
        }

        public bool Equals(Enumeration other)
        {
            return other != null &&
                   Name == other.Name &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            int hashCode = 1460282102;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}
