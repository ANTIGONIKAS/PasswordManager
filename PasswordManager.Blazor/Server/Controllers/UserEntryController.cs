using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PasswordManager.Blazor.Shared.ViewModels.Password;
using PasswordManager.EF.Repositories;
using PasswordManager.Model;

namespace PasswordManager.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class UserEntryController : ControllerBase {

        private IEntityRepo<UserEntry> _userRepo;

        public UserEntryController(IEntityRepo<UserEntry> userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]

        public async Task<IEnumerable<UserEntryViewModel>> Get()
        {
            var result = _userRepo.GetAll();
            return result.Select(x => new UserEntryViewModel
            {
                ID = x.ID,
                MasterUserName = x.MasterUserName,
                MasterPassword = x.MasterPassword,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Phone = x.Phone,
                DateCreated = x.DateCreated,
                Active = x.Active,
             


            });

        }
        [HttpPost]

        public async Task<ActionResult> Post(UserEntryViewModel user)
        {
            UserEntry newUserEntry = new();
            newUserEntry.MasterUserName = user.MasterUserName;
            newUserEntry.MasterPassword = user.MasterPassword;
            newUserEntry.FirstName = user.FirstName;
            newUserEntry.LastName = user.LastName;
            newUserEntry.Phone = user.Phone;
            newUserEntry.DateCreated = user.DateCreated;
            newUserEntry.Active = true;
            _userRepo.Add(newUserEntry);
            return Ok();



        }
        [HttpPut]

        public async Task<ActionResult> Put(UserEntryViewModel newUser)
        {
            var foundUser = _userRepo.GetById(newUser.ID);

            if (foundUser != null)
            {
                foundUser.MasterUserName = newUser.MasterUserName;
                foundUser.MasterPassword = newUser.MasterPassword;
                foundUser.FirstName = newUser.FirstName;
                foundUser.LastName = newUser.LastName;
                foundUser.Phone = newUser.Phone;
                foundUser.DateCreated = newUser.DateCreated;
                foundUser.Active = newUser.Active;
                _userRepo.Update(newUser.ID, foundUser);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

        }
        [HttpGet("{id}")]

        public async Task<UserEntryViewModel> Get(Guid id)
        {
            var result = _userRepo.GetById(id);

            UserEntryViewModel tmp = new();
            tmp.ID = result.ID;
            tmp.MasterUserName = result.MasterUserName;
            tmp.MasterPassword = result.MasterPassword;
            tmp.FirstName = result.FirstName;
            tmp.LastName = result.LastName;
            tmp.Phone = result.Phone;
            tmp.DateCreated = result.DateCreated;
            tmp.Active = result.Active;
            tmp.passwords = result.StoredPasswords;
            return tmp;

        }
        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var foundUser =_userRepo.GetById(id);

            if (foundUser != null)
            {
                _userRepo.Delete(id);
                return Ok();

            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }
    }
}
