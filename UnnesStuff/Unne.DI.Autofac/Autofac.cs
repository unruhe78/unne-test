using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unne.DI;

namespace Unne.DI.Autofac
{
    public static class Autofac
    {
        public static IServiceLocator GetLocator()
        {
            return new ServiceLocator();
        }

        public static IServiceRegistry GetRegistry()
        {
            return new ServiceRegistry();
        }
    }
}
