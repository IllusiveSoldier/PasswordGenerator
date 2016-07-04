namespace PasswordGenerator
{
    partial class Main
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
            this.ShowingPasswordTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePassButton = new System.Windows.Forms.Button();
            this.ReadOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.GetMDFiveSumButton = new System.Windows.Forms.Button();
            this.MDFive = new System.Windows.Forms.TextBox();
            this.ListOfPasswordsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowingPasswordTextBox
            // 
            this.ShowingPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowingPasswordTextBox.Location = new System.Drawing.Point(0, 0);
            this.ShowingPasswordTextBox.Name = "ShowingPasswordTextBox";
            this.ShowingPasswordTextBox.Size = new System.Drawing.Size(325, 20);
            this.ShowingPasswordTextBox.TabIndex = 0;
            this.ShowingPasswordTextBox.DoubleClick += new System.EventHandler(this.ShowingPasswordTextBox_DoubleClick);
            // 
            // GeneratePassButton
            // 
            this.GeneratePassButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneratePassButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GeneratePassButton.Location = new System.Drawing.Point(0, 20);
            this.GeneratePassButton.Name = "GeneratePassButton";
            this.GeneratePassButton.Size = new System.Drawing.Size(325, 23);
            this.GeneratePassButton.TabIndex = 1;
            this.GeneratePassButton.Text = "Generate!";
            this.GeneratePassButton.UseVisualStyleBackColor = true;
            this.GeneratePassButton.Click += new System.EventHandler(this.GeneratePassButton_Click);
            // 
            // ReadOnlyCheckBox
            // 
            this.ReadOnlyCheckBox.AutoSize = true;
            this.ReadOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ReadOnlyCheckBox.Location = new System.Drawing.Point(12, 49);
            this.ReadOnlyCheckBox.Name = "ReadOnlyCheckBox";
            this.ReadOnlyCheckBox.Size = new System.Drawing.Size(79, 18);
            this.ReadOnlyCheckBox.TabIndex = 2;
            this.ReadOnlyCheckBox.Text = "ReadOnly";
            this.ReadOnlyCheckBox.UseVisualStyleBackColor = true;
            this.ReadOnlyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GetMDFiveSumButton
            // 
            this.GetMDFiveSumButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GetMDFiveSumButton.Location = new System.Drawing.Point(238, 69);
            this.GetMDFiveSumButton.Name = "GetMDFiveSumButton";
            this.GetMDFiveSumButton.Size = new System.Drawing.Size(75, 23);
            this.GetMDFiveSumButton.TabIndex = 3;
            this.GetMDFiveSumButton.Text = "Get MD5";
            this.GetMDFiveSumButton.UseVisualStyleBackColor = true;
            this.GetMDFiveSumButton.Click += new System.EventHandler(this.GetMDFiveSumButton_Click);
            // 
            // MDFive
            // 
            this.MDFive.Location = new System.Drawing.Point(12, 71);
            this.MDFive.Name = "MDFive";
            this.MDFive.ReadOnly = true;
            this.MDFive.Size = new System.Drawing.Size(220, 20);
            this.MDFive.TabIndex = 4;
            this.MDFive.DoubleClick += new System.EventHandler(this.MDFive_DoubleClick);
            // 
            // ListOfPasswordsRichTextBox
            // 
            this.ListOfPasswordsRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ListOfPasswordsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOfPasswordsRichTextBox.Location = new System.Drawing.Point(12, 111);
            this.ListOfPasswordsRichTextBox.Name = "ListOfPasswordsRichTextBox";
            this.ListOfPasswordsRichTextBox.Size = new System.Drawing.Size(301, 62);
            this.ListOfPasswordsRichTextBox.TabIndex = 5;
            this.ListOfPasswordsRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сгенерированные пароли:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfPasswordsRichTextBox);
            this.Controls.Add(this.MDFive);
            this.Controls.Add(this.GetMDFiveSumButton);
            this.Controls.Add(this.ReadOnlyCheckBox);
            this.Controls.Add(this.GeneratePassButton);
            this.Controls.Add(this.ShowingPasswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "password generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowingPasswordTextBox;
        private System.Windows.Forms.Button GeneratePassButton;
        private System.Windows.Forms.CheckBox ReadOnlyCheckBox;
        private System.Windows.Forms.Button GetMDFiveSumButton;
        private System.Windows.Forms.TextBox MDFive;
        private System.Windows.Forms.RichTextBox ListOfPasswordsRichTextBox;
        private System.Windows.Forms.Label label1;
    }
}

