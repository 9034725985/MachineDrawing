using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace TeklaWcfService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EvalService : IEvalService 
    {
        List<Eval> evals = new List<Eval>();
        void IEvalService.SubmitEval(Eval eval)
        {
            eval.Id = Guid.NewGuid().ToString();
            evals.Add(eval);
        }

        List<Eval> IEvalService.GetEvals()
        {
            return evals;
        }

        void IEvalService.RemoveEval(string id)
        {
            evals.Remove(evals.Find(e => e.Id.Equals(id)));
        }
    }
}