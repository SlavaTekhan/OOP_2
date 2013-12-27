namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonShowTest = new System.Windows.Forms.Button();
            this.buttonShowAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(44, 26);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(75, 60);
            this.buttonAddTest.TabIndex = 0;
            this.buttonAddTest.Text = "Добавить испытание";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonShowTest
            // 
            this.buttonShowTest.Location = new System.Drawing.Point(44, 158);
            this.buttonShowTest.Name = "buttonShowTest";
            this.buttonShowTest.Size = new System.Drawing.Size(75, 60);
            this.buttonShowTest.TabIndex = 1;
            this.buttonShowTest.Text = "Показать испытания";
            this.buttonShowTest.UseVisualStyleBackColor = true;
            this.buttonShowTest.Click += new System.EventHandler(this.buttonShowTest_Click);
            // 
            // buttonShowAmount
            // 
            this.buttonShowAmount.Location = new System.Drawing.Point(44, 92);
            this.buttonShowAmount.Name = "buttonShowAmount";
            this.buttonShowAmount.Size = new System.Drawing.Size(75, 60);
            this.buttonShowAmount.TabIndex = 2;
            this.buttonShowAmount.Text = "Показать количество испытаний";
            this.buttonShowAmount.UseVisualStyleBackColor = true;
            this.buttonShowAmount.Click += new System.EventHandler(this.buttonShowAmount_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 240);
            this.Controls.Add(this.buttonShowAmount);
            this.Controls.Add(this.buttonShowTest);
            this.Controls.Add(this.buttonAddTest);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonShowTest;
        private System.Windows.Forms.Button buttonShowAmount;
    }
}

