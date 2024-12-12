using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    public class Document
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public Document(string connectionString, User currentUser, Form? mainForm)
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
            DocumentForm form = new DocumentForm();
            form.SetConnectionString(_connectionString);
            form.ShowDialog();
        }
    }
}
