﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TeklaWcfService
{
    [DataContract]
    public class Eval
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string Submitter;
        [DataMember]
        public string Comments;
        [DataMember]
        public DateTime TimeSubmitted; 
    }
}