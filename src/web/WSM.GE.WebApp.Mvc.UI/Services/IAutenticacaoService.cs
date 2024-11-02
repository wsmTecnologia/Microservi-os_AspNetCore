using WSM.GE.WebApp.Mvc.UI.Models;

namespace WSM.GE.WebApp.Mvc.UI.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);

        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
    }
}