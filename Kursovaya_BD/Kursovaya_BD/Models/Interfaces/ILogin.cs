using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace Kursovaya_BD.Models.Interfaces
{
    public interface ILogin
    {
        event EventHandler LoginAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
        bool FirstUserForm(string message);
        void Registration();
        void Login(User user);
    }
}
