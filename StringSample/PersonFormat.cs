using System;
using System.Collections.Generic;
using System.Text;

namespace StringSample
{
    public class PersonFormat
    {
        public PersonFormat(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
        public virtual string ToString(string format) => ToString(format, null);

        public string ToString(string format, IFormatProvider formatProvider) =>
            format switch
            {
                null => string.Empty,
                "A" => ToString(),
                "F" => FirstName,
                "L" => LastName,
                _ => throw new FormatException(string.Format(formatProvider, $"invalid format string {format}"))
            };
    }
}
