using commandAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace commandAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettel & Pan" },
                new Command { Id = 0, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife & chopping board" },
                new Command { Id = 0, HowTo = "Make Cup of tea", Line = "Place Tea Bag in Cup", Platform = "Kettel & Cup" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettel & Pan" };
        }
    }
}
