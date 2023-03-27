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
            var result= _passwordRepo.GetAll();
            return result.Select(x => new PasswordViewModel
            {
                ID = x.ID,
                Password = x.Password,
                UserName = x.UserName,
                DateModified = x.DateModified,
                Site = x.Site,
                Active = x.Active,
                UserID= x.UserID
            });

        }
    }
}
