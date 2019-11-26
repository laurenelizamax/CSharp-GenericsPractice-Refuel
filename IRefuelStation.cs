using System.Collections.Generic;
using System;
using System.Linq;

namespace GenericPracticeRefuel
{
    // Type parameter <T>- variable
    public interface IRefuelStation<T>
    {
        public int Capacity { get; set; }

        void Refuel(List<T> vehicles)
        {
        }

    }
}