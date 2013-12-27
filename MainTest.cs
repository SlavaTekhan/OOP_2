using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP2
{  /**
@class MainTest
Содержит данные которые позволяют опрерировать с информацией.
*/  
    public abstract class MainTest
    {       /// Это поле — закрытое. Доступ к нему возможен только из методов класса _subject 
        private string _subject;
            /// Это поле — закрытое. Доступ к нему возможен только из методов класса _lMainTest, а так же инициализирует новый пустой экзмепляр класса 
        private static List<MainTest> _lMainTest = new List<MainTest>();

        public MainTest(string subject)
        {
            Subject = subject;
        }

        ///Это поле — открытое. Доступ к нему возможен из любого места программы.
        /// set - тело аксессора для записи в поле
        /// get - тело аксессора для чтения из поля
        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }

        ///Это поле — открытое. Доступ к нему возможен из любого места программы.
        /// get - тело аксессора для чтения из поля
        public static List<MainTest> LMainTest
        {
            get { return _lMainTest; }
        }

        ///вывод наименований предметов
        public virtual void GetInfo()
        {
            MessageBox.Show("Предмет: " + Subject);
        }

        ///алгоритм вывода окна, если предметы не были добавлены, иначе - вывод информации
        public static void GetInfoAll()
        {
            if (LMainTest.Count == 0)
            {
                MessageBox.Show("Добавьте испытание.");
            }
            else
            {
                foreach (MainTest test in LMainTest)
                {
                    test.GetInfo();
                }
            }
        }
        ///отображает окно сообщения, содержащее ОБЩЕЙ интересующующей нас информации
        public static void GetInfoAmount()
        {
            ///окно вывода
            MessageBox.Show("Количество испытаний: " + LMainTest.Count + "\n");
        }
    }
}
