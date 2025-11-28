using System;

namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }

        //nullable
        public int? TreeHeight { get; set; }

        // Enum for day of the week
        public enum Day
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // enum
        public Day? DayOfChristmas { get; set; }  // also nullable if needed
    }
}
