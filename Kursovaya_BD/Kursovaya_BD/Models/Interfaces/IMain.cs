using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace Kursovaya_BD.Models.Interfaces
{
    public interface IMain
    {
        event EventHandler FullGrant;
        event EventHandler AccessGrant;
        event EventHandler GetConnection;
        event EventHandler<string> AddClick;
        event EventHandler<string> UpdateClick;
        event EventHandler<string> DeleteClick;
        void Message(string message);
        bool FirstUserForm(string message);
        void BuildMenu(List<Module> module);
        void BuildMenu(List<Module> module, List<Role> userRoles);
        void SendConnection(string connection);
        void OpenForm(string currentDLL, string typeOfOpen);
    }
}
