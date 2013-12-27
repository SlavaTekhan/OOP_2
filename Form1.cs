using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



/** @mainpage @author Вячеслав Трушкин

@full  Программа "object-oriented programming" представляет собой список, а именно базу данных
в которой содержится информация о предметах (выбор: "экзамен, тест, выпускной экзамен"; кол-во баллов и среднюю оценку). 
Реализована сортировка предметов по массивам, в одном из которых указывается кол-во предметов, а в другом последовательно его название, оценку и кол-во баллов.
*/

namespace OOP2
{/**
@class Form1
Содержит данные о экзамене.
*/  
    public partial class Form1 : Form
    {       ///конструктор
        public enum TestS { None = 0, TestPaper = 1, Exam = 2, FinalExam = 3 }
        public Form1()
        {
            InitializeComponent();
        }
        ///при щелчке выводить
        private void buttonAddTest_Click(object sender, EventArgs e)
        {   ///добавление новой формы
            FormAddTest addTest = new FormAddTest();
            if (addTest.ShowDialog() == DialogResult.OK)
            {   ///создание меню
                switch (addTest.TestS)
                {
                    case (int)TestS.TestPaper:
                        TestPaper testPr = addTest.TestPr;
                        MainTest.LMainTest.Add(testPr);
                        break;

                    case (int)TestS.Exam:
                        Exam ex = addTest.Ex;
                        MainTest.LMainTest.Add(ex);
                        break;

                    case (int)TestS.FinalExam:
                        FinalExam finalEx = addTest.FinalEx;
                        MainTest.LMainTest.Add(finalEx);
                        break;
                }
            }
        }
        ///вывод кол-ва испытаний
        private void buttonShowTest_Click(object sender, EventArgs e)
        {
            MainTest.GetInfoAll();
        }
        ///вывод общей информации
        private void buttonShowAmount_Click(object sender, EventArgs e)
        {
            MainTest.GetInfoAmount();
        }
    }
}
