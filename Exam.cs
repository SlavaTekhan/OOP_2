using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP2
{/**
@class Exam
Содержит данные о экзамене.
*/    

    public class Exam : MainTest
     {
        /// Это поле — закрытое. Доступ к нему возможен только из методов класса _gettingScore (полученный балл)
        private int _gettingScore;
        /// Это поле — закрытое. Доступ к нему возможен только из методов класса _mark (оценка)
        private int _mark;

        ///Открытый конструктор. Доступ к нему возможен из любого места программы; gettingScoire (полученный балл) - присваивание параметров.
        ///Mark - (оценка) присваивание параметров.
        ///class System.string - преставляет класс текста для вывода через окошко.
        public Exam(int gettingScore, int mark, string subject)
            : base(subject)
        {   
            GettingScore = gettingScore;
            Mark = mark;
        }
        public int GettingScore
        ///Это поле — открытое. Доступ к нему возможен из любого места программы.
        /// set - тело аксессора для записи в поле
        /// get - тело аксессора для чтения из поля
        {
            set { _gettingScore = value; }

            get { return _gettingScore; }

        }

        public int Mark
        ///Это поле — открытое. Доступ к нему возможен из любого места программы.
        /// set - тело аксессора для записи в поле
        /// get - тело аксессора для чтения из поля
        {
            set { _mark = value; }

            get { return _mark; }

        }

        public override void GetInfo()
        {
            ///отображает окно сообщения, содержащее интересующую нас информацию
            MessageBox.Show("Предмет: " + Subject + "\nПолученный балл: " + GettingScore + "\nОценка: " + Mark);
        }
    }
}
