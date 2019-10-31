using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class Racer : IComparable<Racer>, IFormattable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Wins { get; set; }


        public Racer(int id, string firstName, string lastName, string country)
            : this(id, firstName, lastName, country, wins: 0)
        { }

        public Racer(int id, string firstName, string lastName, string country, int wins)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Country = country;
            this.Wins = wins;
        }

        public override string ToString() => $"{this.FirstName} {this.LastName}";

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "N";
            return (format.ToUpper()) switch
            {
                "N" => this.ToString(),
                "F" => this.FirstName,
                "L" => this.LastName,
                "W" => $"{this.ToString()}, Wins:{this.Wins}",
                "C" => $"{this.ToString()}, Country:{this.Country}",
                "A" => $"{this.ToString()}, Country:{this.Country} Wins:{this.Wins}",
                _ => throw new FormatException(string.Format(formatProvider, $"Format {format} is not supporetd")),
            };
        }

        public string ToString(string format) => this.ToString(format, null);

        public int CompareTo(Racer other)
        {
            int compare = this.LastName?.CompareTo(other?.LastName) ?? -1;
            if (compare == 0)
            {
                return this.FirstName?.CompareTo(other?.FirstName) ?? -1;
            }

            return compare;
        }
    }

    /// <summary>
    /// 查找国家
    /// </summary>
    public class FindCountry
    {
        private readonly string _country;
        public FindCountry(string country)
        {
            this._country = country;
        }

        public bool FindCountryPredict(Racer racer) =>
            racer?.Country == this._country;

    }


    public class RacerComparer: IComparer<Racer>
    {
        public enum CompareType
        {
            FirstName,
            LastName,
            Country,
            Wins
        }

        private readonly CompareType _compareType;

        public RacerComparer(CompareType compareType)
        {
            this._compareType = compareType;
        }

        public int Compare(Racer x, Racer y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            int result;
            switch (this._compareType)
            {
                case CompareType.FirstName:
                    return string.Compare(x.FirstName, y.FirstName);
                case CompareType.LastName:
                    return string.Compare(x.LastName, y.LastName);
                case CompareType.Country:
                    result = string.Compare(x.Country, y.Country);
                    if (result == 0)
                        return string.Compare(x.LastName, y.LastName);
                    else
                        return result;
                case CompareType.Wins:
                    return x.Wins.CompareTo(y.Wins);
                default:
                    throw new ArgumentException("Invalid Compayr Type");
            }
        }
    }
}
