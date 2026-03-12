namespace WinFormsApp11.Forms.Add
{
    partial class AddPple
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
            nameBox = new TextBox();
            SurnameBox = new TextBox();
            LastnameBox = new TextBox();
            SaveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 28);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(211, 23);
            nameBox.TabIndex = 0;
            nameBox.KeyPress += nameBox_KeyPress_1;
            // 
            // SurnameBox
            // 
            SurnameBox.Location = new Point(12, 73);
            SurnameBox.Name = "SurnameBox";
            SurnameBox.Size = new Size(211, 23);
            SurnameBox.TabIndex = 1;
            SurnameBox.KeyPress += nameBox_KeyPress_1;
            // 
            // LastnameBox
            // 
            LastnameBox.Location = new Point(12, 119);
            LastnameBox.Name = "LastnameBox";
            LastnameBox.Size = new Size(211, 23);
            LastnameBox.TabIndex = 2;
            LastnameBox.KeyPress += nameBox_KeyPress_1;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(12, 168);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(211, 23);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Добавить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 6;
            label3.Text = "Отчество(при хорошем настроении)";
            // 
            // AddPple
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPple";
            Text = "Добавить человека";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private TextBox SurnameBox;
        private TextBox LastnameBox;
        private Button SaveButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}