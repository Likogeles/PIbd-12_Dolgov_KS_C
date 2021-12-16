using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    /// <summary>
    /// Класс-ошибка "Если не найдена лодка по определенному месту"
    /// </summary>
    public class DockingNotFoundException : Exception
    {
        public DockingNotFoundException(int i) : base("Не найдена лодка по доку " + i)
        { }
    }
}
