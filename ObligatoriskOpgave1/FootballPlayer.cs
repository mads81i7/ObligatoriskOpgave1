using System;
using System.Security.Principal;

namespace ObligatoriskOpgave1
{
    public class FootballPlayer
    {
        private string _name;
        private double _price;
        private int _shirtNumber;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                {
                    _name = value;
                }
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                {
                    _price = value;
                }
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                {
                    _shirtNumber = value;
                }
            }
        }
    }
}
