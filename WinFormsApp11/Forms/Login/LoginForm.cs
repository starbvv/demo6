using WinFormsApp11.Forms.Login;
using WinFormsApp11.Service;
using WinFormsApp11.Service.ForDB;
namespace WinFormsApp11
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Add();
        }
        private void Add()
        {
            using var db = new Connect();
            db.Database.EnsureCreated();
        }
        private bool CheckValue()
        {
            if(loginBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте логин");
                return false;
            }
            if (passBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте пароль");
                return false;
            }
            return true;
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                if (CheckLogin.CheckValidLogin(loginBox.Text, passBox.Text))
                {
                    MainView main = new MainView();
                    main.ShowDialog();
                }
                this.Close();
            }
        }
    }
}
