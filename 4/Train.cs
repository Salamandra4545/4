using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Train : ICloneable, IComparable

    {
        public string EndPoint { get; private set; }
        public string NumberTrain { get; private set; }
        public string Time { get; private set; }


        public Train(string endpoint, string number, string time)
        {
            EndPoint = endpoint;
            NumberTrain = number;
            Time = time;
        }

        public object Clone()
        {
            return new Train(EndPoint = this.EndPoint, NumberTrain = this.NumberTrain,
                                Time = this.Time);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Train t)
            {
                return string.Compare(this.EndPoint, t?.EndPoint);
            }
            else
                throw new Exception("Невозможно сравнить");


        }

        public override string? ToString()
        {
            return $"Last Station: {EndPoint} Number: {NumberTrain} " +
                $"Time: {Time}";
        }

    }
}
