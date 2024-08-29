using API_IdAu1.Models.Database;
using Microsoft.AspNetCore.Identity;

namespace API_IdAu1.Logic.Repository
{
    public class EmailSender : IEmailSender<Users>
    {
        public Task SendConfirmationLinkAsync(Users user, string email, string confirmationLink)
        {
            // Implementa la lógica para enviar el correo de confirmación
            return Task.CompletedTask;
        }

        public Task SendPasswordResetLinkAsync(Users user, string email, string resetLink)
        {
            // Implementa la lógica para enviar el correo de restablecimiento de contraseña
            return Task.CompletedTask;
        }

        public Task SendPasswordResetCodeAsync(Users user, string email, string resetCode)
        {
            // Implementa la lógica para enviar el código de restablecimiento de contraseña
            return Task.CompletedTask;
        }
    }
}
