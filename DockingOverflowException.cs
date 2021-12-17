using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLaba1
{
    /// <summary>
    /// Класс-ошибка "Если в гавани уже заняты все доки"
    /// </summary>
    class DockingOverflowException : Exception
    {
        public DockingOverflowException() : base("В гавани нет свободных доков")
        { }
    }
}
