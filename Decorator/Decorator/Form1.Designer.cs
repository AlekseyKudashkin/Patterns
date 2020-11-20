namespace Decorator
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
            this.passportCheckBox = new System.Windows.Forms.CheckBox();
            this.insuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.bankCardCheckBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // passportCheckBox
            // 
            this.passportCheckBox.AutoSize = true;
            this.passportCheckBox.Location = new System.Drawing.Point(73, 55);
            this.passportCheckBox.Name = "passportCheckBox";
            this.passportCheckBox.Size = new System.Drawing.Size(75, 17);
            this.passportCheckBox.TabIndex = 0;
            this.passportCheckBox.Text = "Пасспорт";
            this.passportCheckBox.UseVisualStyleBackColor = true;
            this.passportCheckBox.CheckedChanged += new System.EventHandler(this.passportCheckBox_CheckedChanged);
            // 
            // insuranceCheckBox
            // 
            this.insuranceCheckBox.AutoSize = true;
            this.insuranceCheckBox.Location = new System.Drawing.Point(73, 93);
            this.insuranceCheckBox.Name = "insuranceCheckBox";
            this.insuranceCheckBox.Size = new System.Drawing.Size(64, 17);
            this.insuranceCheckBox.TabIndex = 1;
            this.insuranceCheckBox.Text = "СНИЛС";
            this.insuranceCheckBox.UseVisualStyleBackColor = true;
            this.insuranceCheckBox.CheckedChanged += new System.EventHandler(this.insuranceCheckBox_CheckedChanged);
            // 
            // bankCardCheckBox
            // 
            this.bankCardCheckBox.AutoSize = true;
            this.bankCardCheckBox.Location = new System.Drawing.Point(73, 132);
            this.bankCardCheckBox.Name = "bankCardCheckBox";
            this.bankCardCheckBox.Size = new System.Drawing.Size(119, 17);
            this.bankCardCheckBox.TabIndex = 2;
            this.bankCardCheckBox.Text = "Банковская карта";
            this.bankCardCheckBox.UseVisualStyleBackColor = true;
            this.bankCardCheckBox.CheckedChanged += new System.EventHandler(this.bankCardCheckBox_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(198, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1012, 566);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Информация не запрошена.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 590);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bankCardCheckBox);
            this.Controls.Add(this.insuranceCheckBox);
            this.Controls.Add(this.passportCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox passportCheckBox;
        private System.Windows.Forms.CheckBox insuranceCheckBox;
        private System.Windows.Forms.CheckBox bankCardCheckBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

