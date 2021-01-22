using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceWCF
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool ValidateLogin(User user);
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
