using commandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commandAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
