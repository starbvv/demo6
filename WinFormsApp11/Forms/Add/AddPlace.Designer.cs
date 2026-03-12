namespace WinFormsApp11.Forms.Add
{
    partial class AddPlace
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
            DescBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            etazhNumberic = new NumericUpDown();
            numberBox = new TextBox();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)etazhNumberic).BeginInit();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 195);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(214, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DescBox
            // 
            DescBox.Location = new Point(12, 159);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(214, 23);
            DescBox.TabIndex = 1;
            DescBox.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Этаж";
            // 
            // etazhNumberic
            // 
            etazhNumberic.Location = new Point(12, 71);
            etazhNumberic.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            etazhNumberic.Name = "etazhNumberic";
            etazhNumberic.Size = new Size(214, 23);
            etazhNumberic.TabIndex = 5;
            // 
            // numberBox
            // 
            numberBox.Location = new Point(12, 27);
            numberBox.Name = "numberBox";
            numberBox.Size = new Size(214, 23);
            numberBox.TabIndex = 6;
            numberBox.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Категория";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "1-местный бюджет", "2-местный бюджет", "3-местный бюджет", "Бизнес с 1 или 2 кроватями", "Двухкомнатный двухместный стандарт с 1 или 2 кроватями", "Студия", "Люкс с 2 двуспальными кроватями" });
            CategoryComboBox.Location = new Point(12, 115);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(214, 23);
            CategoryComboBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Описание";
            // 
            // AddPlace
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
            Name = "AddPlace";
            Text = "Добавить место";
            ((System.ComponentModel.ISupportInitialize)etazhNumberic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private TextBox DescBox;
        private Label label1;
        private Label label2;
        private NumericUpDown etazhNumberic;
        private TextBox numberBox;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Label label4;
    }
}