using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commandAPI.Data;
using commandAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace commandAPI.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetAllCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
