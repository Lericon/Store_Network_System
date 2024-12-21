using System;
using SharedModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kursovaya_BD.Views;

namespace Kursovaya_BD.Logic.Presenters
{
    public class HelpService
    {
        private MainForm _mainForm;
        public HelpService(string connectionString, User currentUser, MainForm? mainForm)
        {
            _mainForm = mainForm;
        }
        public void GetHelp()
        {
            string helpFilePath = "SpravochnayaSistema.chm";
            if (System.IO.File.Exists(helpFilePath))
            {
                Help.ShowHelp(_mainForm, helpFilePath);
            };
        }
    }
}