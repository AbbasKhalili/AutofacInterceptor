using Castle.DynamicProxy;

namespace AutofacInterceptor.Security
{
    public class SecurityInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            //Inquiry that user has permission do action
            //if yes continue else threw exception
            invocation.Proceed();
        }
    }
}
