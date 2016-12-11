using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unne.DI.Autofac
{
    public class ServiceLocator : IServiceLocator
    {
        public bool IsRegistered(Type serviceType, string implementationKey = null)
        {
            throw new NotImplementedException();
        }

        public bool IsRegistered<TService>(string implementationKey = null)
        {
            throw new NotImplementedException();
        }

        public object Resolve(Type serviceType, string implementationKey = null)
        {
            throw new NotImplementedException();
        }

        public TService Resolve<TService>(string implementationKey = null)
        {
            throw new NotImplementedException();
        }

        public bool TryResolve(Type serviceType, out object serviceInstance, string implementationKey = null)
        {
            throw new NotImplementedException();
        }

        public bool TryResolve<TService>(out TService serviceInstance, string implementationKey = null)
        {
            throw new NotImplementedException();
        }
    }
}
