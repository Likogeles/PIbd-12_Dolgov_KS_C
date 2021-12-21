using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    class BoatComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if(x.GetType().Name == "Boat" && y.GetType().Name == "Boat")
            {
                return ComparerBoat((Boat)x, (Boat)y);
            }
            else if (x.GetType().Name == "Ship" && y.GetType().Name == "Ship")
            {
                return ComparerShip((Ship)x, (Ship)y);
            }
            else if (x.GetType().Name == "Ship" && y.GetType().Name == "Boat")
            {
                return 1;
            }
            return -1;
        }
        private int ComparerBoat(Boat x, Boat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerShip(Ship x, Ship y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Lines != y.Lines)
            {
                return x.Lines.CompareTo(y.Lines);
            }
            if (x.Window != y.Window)
            {
                return x.Window.CompareTo(y.Window);
            }
            if (x.Rotors != y.Rotors)
            {
                return x.Rotors.CompareTo(y.Rotors);
            }
            if (x.RotorsNum != y.RotorsNum)
            {
                return x.RotorsNum.CompareTo(y.RotorsNum);
            }
            return 0;
        }
    }
}
