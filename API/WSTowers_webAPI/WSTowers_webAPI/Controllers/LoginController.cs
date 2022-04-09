using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WSTowers_webAPI.Contexts;

namespace WSTowers_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly WSContext ctx = new();

        //[HttpPost]
        //public IActionResult Logar(string usuario)
        //{

            //Ao entrar na aplicação será solicitado o usuário e a senha.
            //O usuário será a 1ª letra do nome e o segundo nome(Exemplo: ALINE CONSTATINO = ACONSTATINO)
            //Não é necessário validar maiúscula e minúscula(no case sensitive).
            //A senha será composta por: sigla do estado, sexo e idade(Exemplo: SPF52)

            /// Lógica iniciada, mas ainda não aplicada
            /// 
            //string nome = usuario.Substring(0, 1) + usuario.Split(new char[] { ' ' })[1];

            //return Ok(ctx.Participantes.Where(c => c.Nome.StartsWith(usuario.Substring(0, 1)) && c.Nome.EndsWith(usuario.Remove(0, 1))));

            //ctx.Participantes.FirstOrDefault(c => c.Nome.Substring(0, 1) + c.Nome.Split(new char[] { ' ' })[1] == usuario);
        //}
    }
}
