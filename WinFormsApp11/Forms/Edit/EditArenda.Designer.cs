namespace WinFormsApp11.Forms.Edit
{
    partial class EditArenda
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
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 160);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 23);
            dateTimePicker2.TabIndex = 17;
            dateTimePicker2.Value = new DateTime(2026, 3, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 16;
            label4.Text = "Дата выезда";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2026, 3, 11, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 14;
            label3.Text = "Дата заезда";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 23);
            comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 12;
            label2.Text = "Выбрать человека";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 10;
            label1.Text = "Выбрать номер";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 217);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(214, 23);
            SaveButton.TabIndex = 9;
            SaveButton.Text = "Изменить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditArenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 251);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Name = "EditArenda";
            Text = "Редактировать аренду";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button SaveButton;
    }
}