using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto) //CreateNewUserDto 'dan parametre türetiyoruz
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()  //AppUser sınıfındaki propertylerimizi CreateNewUserDtodakilerle eşliyoruz
            {
                Name = createNewUserDto.Name,
                Surname = createNewUserDto.Surname,
                Email = createNewUserDto.Mail,
                UserName = createNewUserDto.UserName,
                City = "",
                ImageUrl = "",
                WorkDepartment = "",
                Gender = "",
                Country = "",
                WorkLocationID = 1
            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            //CreateAsync metodu UserManager ile beraber gelen bir metottur,
            //Identity kütüphanesinde yeni bir kayıt oluşturmak için kullanılır. Şifreyi bu metotla göndeririz.

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
