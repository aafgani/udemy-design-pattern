﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Interface
{
    public interface ISpecifyWheelSize
    {
        public IBuildCar WithWeels(int size);
    }
}
