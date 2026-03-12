namespace WinFormsApp11.Forms.Add
{
    partial class AddCheckArenda
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
            ArendaComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            dateTimeValue = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 163);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(214, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ArendaComboBox
            // 
            ArendaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ArendaComboBox.FormattingEnabled = true;
            ArendaComboBox.Location = new Point(12, 31);
            ArendaComboBox.Name = "ArendaComboBox";
            ArendaComboBox.Size = new Size(214, 23);
            ArendaComboBox.TabIndex = 1;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "Чистый", "Занят", "Назначен к уборке", "Грязный" });
            StatusComboBox.Location = new Point(12, 119);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(214, 23);
            StatusComboBox.TabIndex = 3;
            // 
            // dateTimeValue
            // 
            dateTimeValue.Location = new Point(12, 75);
            dateTimeValue.Name = "dateTimeValue";
            dateTimeValue.Size = new Size(214, 23);
            dateTimeValue.TabIndex = 4;
            dateTimeValue.Value = new DateTime(2026, 3, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 5;
            label1.Text = "Выбрать номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 6;
            label2.Text = "Последняя дата выезда из номера";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Статус номера";
            // 
            // AddCheckArenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 198);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimeValue);
            Controls.Add(StatusComboBox);
            Controls.Add(ArendaComboBox);
            Controls.Add(SaveButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCheckArenda";
            Text = "Добавить статус номера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private ComboBox ArendaComboBox;
        private ComboBox StatusComboBox;
        private DateTimePicker dateTimeValue;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}