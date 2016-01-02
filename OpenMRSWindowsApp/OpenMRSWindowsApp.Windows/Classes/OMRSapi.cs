
using System.Runtime.Serialization;


namespace OpenMRSWindowsApp.Classes
{
    [DataContract]
    public class OMRSapi
    {
        [DataMember(Name = "sessionID")]
        public string sessionId { get; set; }
        [DataMember(Name = "authenticated")]
        public bool authenticated { get; set; }
    }

}
