using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    public enum CarType
    {
        Sedan,
        Crossover
    }

    public class Car
    {
        public CarType Type { get; set; }
        public int WheelSize { get; set; }

        public override string? ToString()
        {
            return $"{nameof(Type)} : {Type}, {nameof(WheelSize)} : {WheelSize}";
        }
    }
}
