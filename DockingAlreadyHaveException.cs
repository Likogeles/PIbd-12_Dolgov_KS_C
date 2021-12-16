using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    /// <summary>
    /// Класс-ошибка "Если в доке уже есть судно с такими же характеристиками"
    /// </summary>
    public class DockingAlreadyHaveException : Exception
    {
        public DockingAlreadyHaveException() : base("В гавани уже есть такое судно")
        { }
    }
}
