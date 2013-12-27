using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP2
{
    public partial class FormAddTest : Form
    {
        public int TestS { get; set; }
        public TestPaper TestPr { get; set; }
        public Exam Ex { get; set; }
        public FinalExam FinalEx { get; set; }

        public FormAddTest()
        {
            InitializeComponent();
        }

        private void checkBoxTestPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTestPaper.Checked)
            {
                if (checkBoxExam.Checked)
                    checkBoxExam.Checked = false;
                if (checkBoxFinalExam.Checked)
                    checkBoxFinalExam.Checked = false;
                TestS = (int)Form1.TestS.TestPaper;
            }
            else
            {
                TestS = (int)Form1.TestS.None;
            }
        }

        private void checkBoxExam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExam.Checked)
            {
                if (checkBoxTestPaper.Checked)
                    checkBoxTestPaper.Checked = false;
                if (checkBoxFinalExam.Checked)
                    checkBoxFinalExam.Checked = false;
                TestS = (int)Form1.TestS.Exam;
            }
            else
            {
                TestS = (int)Form1.TestS.None;
            }
        }

        private void checkBoxFinalExam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFinalExam.Checked)
            {
                if (checkBoxTestPaper.Checked)
                    checkBoxTestPaper.Checked = false;
                if (checkBoxExam.Checked)
                    checkBoxExam.Checked = false;
                TestS = (int)Form1.TestS.FinalExam;
            }
            else
            {
                TestS = (int)Form1.TestS.None;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            switch (TestS)
            {
                case(int)Form1.TestS.TestPaper:
                    TestPr = new TestPaper((int)numericUpDownGettingScore.Value, (int)numericUpDownMark.Value, textBoxSubject.Text);
                    break;

                case (int)Form1.TestS.Exam:
                    Ex = new Exam((int)numericUpDownGettingScore.Value, (int)numericUpDownMark.Value, textBoxSubject.Text);
                    break;

                case (int)Form1.TestS.FinalExam:
                    FinalEx = new FinalExam((int)numericUpDownGettingScore.Value, (int)numericUpDownMark.Value, textBoxSubject.Text);
                    break;
            }
        }
    }
}
