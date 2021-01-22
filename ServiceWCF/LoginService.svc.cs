namespace ServiceWCF
{
    public class LoginService : ILoginService
    {
        public bool ValidateLogin(User user)
        {
            return user.Login == "cesar.rrguez" && user.Password == "123456";
        }
    }
}
