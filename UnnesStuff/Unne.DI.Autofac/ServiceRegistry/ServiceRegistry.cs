using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unne.DI.Autofac
{
    public class ServiceRegistry : IServiceRegistry
    {
        public void RegisterType(Type serviceType, Type implementationType, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null)
        {
            #region Parameter Validation

            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException(nameof(implementationType));
            }

            if(!serviceType.IsAssignableFrom(implementationType))
            {
                throw new ArgumentOutOfRangeException(nameof(implementationType), implementationType, $"{nameof(implementationType)} doesn't implement {nameof(serviceType)}");
            }

            #endregion

            throw new NotImplementedException();
        }

        public void RegisterType<TService, TImplementation>(LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null) where TImplementation : TService
        {
            this.RegisterType(typeof(TService), typeof(TImplementation), scope, implementationKey);
        }

        public void RegisterTypeFactory(Type serviceType, Func<object> factoryMethod, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null)
        {
            #region Parameter Validation

            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            if (factoryMethod == null)
            {
                throw new ArgumentNullException(nameof(factoryMethod));
            }

            if (!serviceType.IsAssignableFrom(factoryMethod().GetType()))
            {
                throw new ArgumentOutOfRangeException(nameof(factoryMethod), factoryMethod, $"Return value of {nameof(factoryMethod)}() doesn't implement {nameof(serviceType)}");
            }

            #endregion

            throw new NotImplementedException();
        }

        public void RegisterTypeFactory<TService>(Func<TService> factoryMethod, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null)
        {
            this.RegisterTypeFactory(typeof(TService), () => factoryMethod(), scope, implementationKey);
        }
    }
}
