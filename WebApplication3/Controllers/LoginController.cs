using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return Json(new { Msg = "Usuário Já logado!" });
            }
            return View();
        }

        public IActionResult Catalogo()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public async Task <IActionResult> Logar(string username, string senha)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;database=usuariosdb;uid=root;password=root");
            await mySqlConnection.OpenAsync();

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = $"SELECT * FROM usuarios WHERE username = '{username}' AND password = '{senha}'";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            
            if (await reader.ReadAsync())
            {
                int usuarioId = reader.GetInt32(0);
                string nome = reader.GetString(1);

                List<Claim> direitosAcesso = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, usuarioId.ToString()),
                    new Claim(ClaimTypes.Name, nome)
                };

                var identify = new ClaimsIdentity(direitosAcesso, "Idetify.Login");
                var userPrincipal = new ClaimsPrincipal(new[] { identify });

                await HttpContext.SignInAsync(userPrincipal,

                    new AuthenticationProperties {
                        IsPersistent = false,
                        ExpiresUtc = DateTime.Now.AddHours(1)
                    });

                return RedirectToAction("Catalogo", "Login");
            }

            return RedirectToAction("Index", "Login");
        }

        public async Task<IActionResult> Logout()
        {
            if(User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();

            }
            return RedirectToAction("Index", "Login");
        }
    }
    
}