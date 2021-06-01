using System.Runtime.Serialization;

namespace Core.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Firstname;

        [DataMember]
        public string Lastname;

        [DataMember]
        public string Points;

        [DataMember]
        public int Age;
    }
}