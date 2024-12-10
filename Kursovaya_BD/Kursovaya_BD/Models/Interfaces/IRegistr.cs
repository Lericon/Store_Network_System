using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_BD.Models.Interfaces
{
    public interface IRegistr
    {
        event EventHandler RegistrationAttempt;
        List<string> GetLoginPassword();
        void Message(string message);
        void Close();
    }
}
