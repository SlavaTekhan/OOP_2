namespace OOP2
{
    partial class FormAddTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.checkBoxTestPaper = new System.Windows.Forms.CheckBox();
            this.checkBoxExam = new System.Windows.Forms.CheckBox();
            this.checkBoxFinalExam = new System.Windows.Forms.CheckBox();
            this.numericUpDownGettingScore = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGettingScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 19);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(55, 13);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Предмет:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(73, 12);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(209, 20);
            this.textBoxSubject.TabIndex = 1;
            // 
            // checkBoxTestPaper
            // 
            this.checkBoxTestPaper.AutoSize = true;
            this.checkBoxTestPaper.Location = new System.Drawing.Point(12, 55);
            this.checkBoxTestPaper.Name = "checkBoxTestPaper";
            this.checkBoxTestPaper.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTestPaper.TabIndex = 2;
            this.checkBoxTestPaper.Text = "Тест";
            this.checkBoxTestPaper.UseVisualStyleBackColor = true;
            this.checkBoxTestPaper.CheckedChanged += new System.EventHandler(this.checkBoxTestPaper_CheckedChanged);
            // 
            // checkBoxExam
            // 
            this.checkBoxExam.AutoSize = true;
            this.checkBoxExam.Location = new System.Drawing.Point(12, 78);
            this.checkBoxExam.Name = "checkBoxExam";
            this.checkBoxExam.Size = new System.Drawing.Size(71, 17);
            this.checkBoxExam.TabIndex = 3;
            this.checkBoxExam.Text = "Экзамен";
            this.checkBoxExam.UseVisualStyleBackColor = true;
            this.checkBoxExam.CheckedChanged += new System.EventHandler(this.checkBoxExam_CheckedChanged);
            // 
            // checkBoxFinalExam
            // 
            this.checkBoxFinalExam.AutoSize = true;
            this.checkBoxFinalExam.Location = new System.Drawing.Point(12, 101);
            this.checkBoxFinalExam.Name = "checkBoxFinalExam";
            this.checkBoxFinalExam.Size = new System.Drawing.Size(129, 17);
            this.checkBoxFinalExam.TabIndex = 4;
            this.checkBoxFinalExam.Text = "Выпускной экзамен";
            this.checkBoxFinalExam.UseVisualStyleBackColor = true;
            this.checkBoxFinalExam.CheckedChanged += new System.EventHandler(this.checkBoxFinalExam_CheckedChanged);
            // 
            // numericUpDownGettingScore
            // 
            this.numericUpDownGettingScore.Location = new System.Drawing.Point(186, 71);
            this.numericUpDownGettingScore.Name = "numericUpDownGettingScore";
            this.numericUpDownGettingScore.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownGettingScore.TabIndex = 5;
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Location = new System.Drawing.Point(186, 110);
            this.numericUpDownMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMark.TabIndex = 6;
            this.numericUpDownMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Полученный балл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Оценка:";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(126, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(207, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 190);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMark);
            this.Controls.Add(this.numericUpDownGettingScore);
            this.Controls.Add(this.checkBoxFinalExam);
            this.Controls.Add(this.checkBoxExam);
            this.Controls.Add(this.checkBoxTestPaper);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Name = "FormAddTest";
            this.Text = "FormAddTest";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGettingScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.CheckBox checkBoxTestPaper;
        private System.Windows.Forms.CheckBox checkBoxExam;
        private System.Windows.Forms.CheckBox checkBoxFinalExam;
        private System.Windows.Forms.NumericUpDown numericUpDownGettingScore;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}
