namespace Unne.DI
{
    using System;

    /// <summary>
    /// Defines an object to register services to be resolved later
    /// </summary>
    public interface IServiceRegistry
    {
        /// <summary>
        /// Registers a mapping of the specified implementation type to the specified service type
        /// </summary>
        /// <param name="serviceType">Type of the service to register</param>
        /// <param name="implementationType">Type of the implementation to return on resolution request</param>
        /// <param name="scope">The lifetime scope of a resolved service implementation</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType"/></param>
        void RegisterType(Type serviceType, Type implementationType, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null);

        /// <summary>
        /// Registers a mapping of the specified implementation type to the specified service type
        /// </summary>
        /// <typeparam name="TService">Type of the service to register</typeparam>
        /// <typeparam name="TImplementation">Type of the implementation to return on resolution request</typeparam>
        /// <param name="scope">The lifetime scope of a resolved service implementation</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType" /></param>
        void RegisterType<TService, TImplementation>(LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null) where TImplementation : TService;

        /// <summary>
        /// Registers a mapping of the specified factory method to the specified service type
        /// </summary>
        /// <param name="serviceType">Type of the service to register</param>
        /// <param name="factoryMethod">Method to create a new instance of a service implementation</param>
        /// <param name="scope">The lifetime scope of a resolved service implementation</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType"/></param>
        void RegisterTypeFactory(Type serviceType, Func<object> factoryMethod, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null);

        /// <summary>
        /// Registers a mapping of the specified factory method to the specified service type
        /// </summary>
        /// <typeparam name="TService">Type of the service to register</typeparam>
        /// <param name="factoryMethod">Method to create a new instance of a service implementation</param>
        /// <param name="scope">The lifetime scope of a resolved service implementation</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType" /></param>
        void RegisterTypeFactory<TService>(Func<TService> factoryMethod, LifetimeScope scope = LifetimeScope.PerDependency, string implementationKey = null);
    }
}
