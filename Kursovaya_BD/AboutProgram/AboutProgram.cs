using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutProgram
{
    public class AboutProgram
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public AboutProgram(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }

        public void OpenForm()
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }
    }
}
