using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [DataContract]
    class Eval
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string Submitter;
        [DataMember]
        public DateTime TimeSubmitted;
    }
}
