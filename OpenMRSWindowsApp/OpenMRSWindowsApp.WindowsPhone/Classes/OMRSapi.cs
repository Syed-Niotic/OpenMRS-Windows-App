using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
