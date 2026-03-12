namespace WinFormsApp11
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passLabel = new Label();
            loginLabel = new Label();
            passBox = new TextBox();
            loginBox = new TextBox();
            openButton = new Button();
            SuspendLayout();
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(14, 70);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(49, 15);
            passLabel.TabIndex = 14;
            passLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(14, 13);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 13;
            loginLabel.Text = "Логин";
            // 
            // passBox
            // 
            passBox.Location = new Point(14, 88);
            passBox.MaxLength = 25;
            passBox.Name = "passBox";
            passBox.Size = new Size(301, 23);
            passBox.TabIndex = 12;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(14, 31);
            loginBox.MaxLength = 100;
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(301, 23);
            loginBox.TabIndex = 11;
            // 
            // openButton
            // 
            openButton.Location = new Point(14, 143);
            openButton.Name = "openButton";
            openButton.Size = new Size(301, 23);
            openButton.TabIndex = 10;
            openButton.Text = "Войти";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 179);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            Controls.Add(openButton);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passLabel;
        private Label loginLabel;
        private TextBox passBox;
        private TextBox loginBox;
        private Button openButton;
    }
}
