namespace WinFormsApp11.Forms.Edit
{
    partial class EditPple
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SaveButton = new Button();
            LastnameBox = new TextBox();
            SurnameBox = new TextBox();
            nameBox = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 102);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 13;
            label3.Text = "Отчество(при хорошем настроении)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 56);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 11;
            label1.Text = "Имя";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(14, 169);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(211, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Изменить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // LastnameBox
            // 
            LastnameBox.Location = new Point(14, 120);
            LastnameBox.Name = "LastnameBox";
            LastnameBox.Size = new Size(211, 23);
            LastnameBox.TabIndex = 9;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(14, 74);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(211, 23);
            SurnameBox.TabIndex = 8;
            SurnameBox.KeyPress += nameBox_KeyPress;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(14, 29);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(211, 23);
            nameBox.TabIndex = 7;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // EditPple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 202);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(LastnameBox);
            Controls.Add(SurnameBox);
            Controls.Add(nameBox);
            Name = "EditPple";
            Text = "Редактировать человека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button SaveButton;
        private TextBox LastnameBox;
        private TextBox SurnameBox;
        private TextBox nameBox;
    }
}