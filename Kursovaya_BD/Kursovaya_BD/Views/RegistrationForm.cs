using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursovaya_BD.Models.Interfaces;
using Kursovaya_BD.Presenters;

namespace Kursovaya_BD.Views
{
    public partial class RegistrationForm : Form, IRegistr
    {
        private readonly RegistrationPresenter _presenter;
        public RegistrationForm()
        {
            InitializeComponent();
            _presenter = new RegistrationPresenter(this);

            this.KeyPreview = true;
            VersionLabel.AutoSize = true;
            VersionLabel.Text = "Версия: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            int xt = RegistrationTopPanel.Width - VersionLabel.Width - 5;
            int yt = 10;

            VersionLabel.Location = new System.Drawing.Point(xt, yt);

            CapsLockLabel.Text = "CapsLock: " + (Console.CapsLock ? "Включен" : "Выключен");

            int xb = RegistrationBottomPanel.Width - CapsLockLabel.Width - 5;
            int yb = RegistrationBottomPanel.Height - CapsLockLabel.Height - 12;

            CapsLockLabel.Location = new System.Drawing.Point(xb, yb);

            var CurrentLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;

            LanguageLabel.Text = "Язык ввода: " + CurrentLanguage;

            InputLanguageChanged += RegistrationForm_InputLanguageChanged;
        }

        public event EventHandler RegistrationAttempt;

        private void RegistrationForm_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            var CurrentLanguage = InputLanguage.CurrentInputLanguage.Culture.NativeName;
            LanguageLabel.Text = "Язык ввода: " + CurrentLanguage;
        }

        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                CapsLockLabel.Text = "CapsLock: " + (Console.CapsLock ? "Включен" : "Выключен");
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationAttempt?.Invoke(this, EventArgs.Empty);
        }

        public List<string> GetLoginPassword()
        {
            List<string> result = new List<string>
            {
                LoginTextBox.Text,
                PasswordTextBox.Text,
                RepeatPasswordTextBox.Text
            };
            return result;
        }

        public void Message(string message)
        {
            Message messageform = new Message(message);
            messageform.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Close()
        {
            this.FormClosing -= RegistrationForm_FormClosing;
            this.Dispose();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FirstUserForm form = new FirstUserForm("Вы уверены, что хотите прервать регистрацию?");
            if (form.ShowDialog() == DialogResult.OK)
            {
                e.Cancel = false;
                Message("Регистрация прекращена пользователем");
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
