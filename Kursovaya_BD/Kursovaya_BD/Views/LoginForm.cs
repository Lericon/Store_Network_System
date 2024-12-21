using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedModels;
using Kursovaya_BD.Models.Interfaces;
using Kursovaya_BD.Presenters;

namespace Kursovaya_BD.Views
{
    public partial class LoginForm : Form, ILogin
    {
        private readonly LoginPresenter _presenter;
        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);

            this.KeyPreview = true;
            VersionLabel.AutoSize = true;
            VersionLabel.Text = "¬ерси€: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            int xt = LoginTopPanel.Width - VersionLabel.Width - 5;
            int yt = 10;

            VersionLabel.Location = new System.Drawing.Point(xt, yt);

            var CurrentLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;

            LanguageLabel.Text = "язык ввода: " + CurrentLanguage;

            InputLanguageChanged += LoginForm_InputLanguageChanged;
        }

        public event EventHandler LoginAttempt;

        private void LoginForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            var CurrentLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;
            LanguageLabel.Text = "язык ввода: " + CurrentLanguage;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginAttempt?.Invoke(this, EventArgs.Empty);
        }

        public List<string> GetLoginPassword()
        {
            List<string> result = new List<string>
            {
                LoginTextBox.Text,
                PasswordTextBox.Text
            };
            return result;
        }

        public void Message(string message)
        {
            Message messageform = new Message(message);
            messageform.ShowDialog();
        }

        public bool FirstUserForm(string message)
        {
            FirstUserForm form = new FirstUserForm(message);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Login(User user)
        {
            MainForm form = new MainForm(user);
            this.Visible = false;
            form.ShowDialog();
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            this.Visible = true;
        }

        public void Registration()
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FirstUserForm form = new FirstUserForm("¬ы уверены, что хотите закрыть программу?");
            if (form.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
