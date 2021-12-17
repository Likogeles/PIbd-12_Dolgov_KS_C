using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    class DockingNotLoadBoatException : Exception
    {
        public DockingNotLoadBoatException() : base("Не удалось загрузить лодку в гавань")
        { }
    }
}
