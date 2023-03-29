using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Blazor.Shared.ViewModels.Password;
using PasswordManager.EF.Repositories;
using PasswordManager.Model;

namespace PasswordManager.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase {
        private IEntityRepo<PasswordEntry> _passwordRepo;

        public PasswordController(IEntityRepo<PasswordEntry> passwordRepo)
        {
            _passwordRepo = passwordRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<PasswordViewModel>> Get()
        {
            var result = _passwordRepo.GetAll();
            return result.Select(x => new PasswordViewModel
            {
                ID = x.ID,
                Password = x.Password,
                UserName = x.UserName,
                DateModified = x.DateModified,
                Site = x.Site,
                Active = x.Active,
                UserID = x.UserID
            });

        }
        //TODO: When UserEntry is fixed return to correct line 44
        [HttpPost]
        public async Task<ActionResult> Post(PasswordViewModel password)
        {
            PasswordEntry newPasswordEntry = new();
            newPasswordEntry.Site = password.Site;
            newPasswordEntry.UserName = password.UserName;
            newPasswordEntry.Password = password.Password;
            newPasswordEntry.DateModified = DateTime.Now;
            newPasswordEntry.Active = true;
            newPasswordEntry.UserID = new Guid("A2C154CD-BEE6-42D4-A0A1-36AE84D23F44");
            _passwordRepo.Add(newPasswordEntry);
            return Ok();


        }
        [HttpPut]
        public async Task<ActionResult> Put(PasswordViewModel incoming)
        {
            var foundEntry=_passwordRepo.GetById(incoming.ID);
                        
            if(foundEntry != null)
            {
                foundEntry.UserName = incoming.UserName;
                foundEntry.Password = incoming.Password;
                foundEntry.DateModified= DateTime.Now;
                foundEntry.Site = incoming.Site;
                foundEntry.Active = incoming.Active;
                _passwordRepo.Update(incoming.ID, foundEntry);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpGet("{id}")]
        public async Task<PasswordViewModel> Get(Guid id)
        {
            var result = _passwordRepo.GetById(id);
            PasswordViewModel tmp = new();
            tmp.ID = result.ID;
            tmp.Active = result.Active;
            tmp.Site = result.Site;
            tmp.DateModified = result.DateModified;
            tmp.UserID = result.UserID;
            tmp.UserName = result.UserName;
            tmp.Password = result.Password;
            return tmp;
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var foundEntry = _passwordRepo.GetById(id);

            if (foundEntry != null)
            {
                _passwordRepo.Delete(id);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }


    }

    
}
