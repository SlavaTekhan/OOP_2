using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOP2
{/**
@class Program
Класс, являющийся главной точкой входа для приложения.
*/

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            ///включает визуальные стили для приложения
            Application.SetCompatibleTextRenderingDefault(false);
            ///задает значения по умолчанию во всем приложении для этого свойства
            Application.Run(new Form1());
            ///запускает стандартный цикл обработки соощений
        }
    }
}
