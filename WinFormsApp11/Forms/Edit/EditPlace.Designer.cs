namespace WinFormsApp11.Forms.Edit
{
    partial class EditPlace
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
            SaveButton = new Button();
            label4 = new Label();
            CategoryComboBox = new ComboBox();
            label3 = new Label();
            numberBox = new TextBox();
            etazhNumberic = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            DescBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)etazhNumberic).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 197);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(214, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Изменить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 18;
            label4.Text = "Описание";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "1-местный бюджет", "2-местный бюджет", "3-местный бюджет", "Бизнес с 1 или 2 кроватями", "Двухкомнатный двухместный стандарт с 1 или 2 кроватями", "Студия", "Люкс с 2 двуспальными кроватями" });
            CategoryComboBox.Location = new Point(12, 115);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(214, 23);
            CategoryComboBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 16;
            label3.Text = "Категория";
            // 
            // numberBox
            // 
            numberBox.Location = new Point(12, 27);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(214, 23);
            numberBox.TabIndex = 15;
            // 
            // etazhNumberic
            // 
            etazhNumberic.Location = new Point(12, 71);
            etazhNumberic.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            etazhNumberic.Name = "etazhNumberic";
            etazhNumberic.Size = new Size(214, 23);
            etazhNumberic.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 13;
            label2.Text = "Этаж";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 12;
            label1.Text = "Номер";
            // 
            // DescBox
            // 
            DescBox.Location = new Point(12, 159);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(214, 23);
            DescBox.TabIndex = 11;
            // 
            // EditPlace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 230);
            Controls.Add(label4);
            Controls.Add(CategoryComboBox);
            Controls.Add(label3);
            Controls.Add(numberBox);
            Controls.Add(etazhNumberic);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescBox);
            Controls.Add(SaveButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPlace";
            Text = "Редактировать место";
            ((System.ComponentModel.ISupportInitialize)etazhNumberic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private Label label4;
        private ComboBox CategoryComboBox;
        private Label label3;
        private TextBox numberBox;
        private NumericUpDown etazhNumberic;
        private Label label2;
        private Label label1;
        private TextBox DescBox;
    }
}