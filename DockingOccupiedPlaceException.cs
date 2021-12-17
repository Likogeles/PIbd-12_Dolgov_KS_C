using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    class DockingOccupiedPlaceException : Exception
    {
        public DockingOccupiedPlaceException() : base("Занятое место")
        { }
    }
}
