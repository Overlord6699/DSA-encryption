
namespace TILab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.InputButton = new System.Windows.Forms.Button();
            this.SignRB = new System.Windows.Forms.RadioButton();
            this.CheckRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.HashTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.STextBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите q:";
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(15, 69);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.Size = new System.Drawing.Size(214, 20);
            this.PTextBox.TabIndex = 2;
            this.PTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PTextBox_KeyPress);
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(15, 25);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(214, 20);
            this.QTextBox.TabIndex = 1;
            this.QTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите h:";
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(15, 108);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(214, 20);
            this.HTextBox.TabIndex = 3;
            this.HTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите x:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите k:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(15, 151);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(214, 20);
            this.XTextBox.TabIndex = 4;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XTextBox_KeyPress);
            // 
            // KTextBox
            // 
            this.KTextBox.Location = new System.Drawing.Point(15, 200);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(214, 20);
            this.KTextBox.TabIndex = 5;
            this.KTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KTextBox_KeyPress);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Enabled = false;
            this.ProcessButton.Location = new System.Drawing.Point(544, 134);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(102, 52);
            this.ProcessButton.TabIndex = 7;
            this.ProcessButton.Text = "Запуск";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(440, 134);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(98, 52);
            this.InputButton.TabIndex = 6;
            this.InputButton.Text = "Ввод";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // SignRB
            // 
            this.SignRB.AutoSize = true;
            this.SignRB.Checked = true;
            this.SignRB.Location = new System.Drawing.Point(278, 134);
            this.SignRB.Name = "SignRB";
            this.SignRB.Size = new System.Drawing.Size(69, 17);
            this.SignRB.TabIndex = 12;
            this.SignRB.TabStop = true;
            this.SignRB.Text = "Подпись";
            this.SignRB.UseVisualStyleBackColor = true;
            this.SignRB.CheckedChanged += new System.EventHandler(this.SignRB_CheckedChanged);
            // 
            // CheckRB
            // 
            this.CheckRB.AutoSize = true;
            this.CheckRB.Location = new System.Drawing.Point(278, 162);
            this.CheckRB.Name = "CheckRB";
            this.CheckRB.Size = new System.Drawing.Size(75, 17);
            this.CheckRB.TabIndex = 13;
            this.CheckRB.Text = "Проверка";
            this.CheckRB.UseVisualStyleBackColor = true;
            this.CheckRB.CheckedChanged += new System.EventHandler(this.CheckRB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "HASH:";
            // 
            // HashTextBox
            // 
            this.HashTextBox.Location = new System.Drawing.Point(61, 233);
            this.HashTextBox.Multiline = true;
            this.HashTextBox.Name = "HashTextBox";
            this.HashTextBox.Size = new System.Drawing.Size(719, 32);
            this.HashTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "S:";
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(36, 287);
            this.RTextBox.Multiline = true;
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(266, 151);
            this.RTextBox.TabIndex = 18;
            // 
            // STextBox
            // 
            this.STextBox.Location = new System.Drawing.Point(522, 287);
            this.STextBox.Multiline = true;
            this.STextBox.Name = "STextBox";
            this.STextBox.Size = new System.Drawing.Size(266, 151);
            this.STextBox.TabIndex = 19;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(664, 115);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(116, 30);
            this.OpenFileButton.TabIndex = 20;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(664, 151);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(116, 38);
            this.SaveFileButton.TabIndex = 21;
            this.SaveFileButton.Text = "Сохранить";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Сообщение:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(253, 25);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(527, 80);
            this.MessageTextBox.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.STextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HashTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckRB);
            this.Controls.Add(this.SignRB);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.KTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox KTextBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.RadioButton SignRB;
        private System.Windows.Forms.RadioButton CheckRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HashTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox STextBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

