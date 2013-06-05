using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace TeklaWcfService
{
    [ServiceContract]
    public interface IEvalService
    {
        [OperationContract]
        void SubmitEval(Eval eval);
        [OperationContract] 
        List<Eval> GetEvals();
        [OperationContract]
        void RemoveEval(string id);
    }
}