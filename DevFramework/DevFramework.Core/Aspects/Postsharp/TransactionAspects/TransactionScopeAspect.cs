using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DevFramework.Core.Aspects.Postsharp.TransactionAspects
{
    [Serializable]
    public  class TransactionScopeAspect :OnMethodBoundaryAspect
    {
        public TransactionScopeAspect()
        {

        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope();

        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
