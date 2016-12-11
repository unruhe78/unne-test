namespace Unne.DI
{
    using System;

    /// <summary>
    /// Defines an object to locate registered services
    /// </summary>
    public interface IServiceLocator
    {
        /// <summary>
        /// Determines whether the specified service is registered
        /// </summary>
        /// <param name="serviceType">Type of the service</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType"/></param>
        /// <returns><c>true</c> if the specified <paramref name="serviceType"/> is registered; otherwise <c>false</c></returns>
        bool IsRegistered(Type serviceType, string implementationKey = null);

        /// <summary>
        /// Determines whether the specified service is registered
        /// </summary>
        /// <typeparam name="TService">Type of the service</typeparam>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <typeparamref name="TService"/></param>
        /// <returns><c>true</c> if the specified <paramref name="serviceType"/> is registered; otherwise <c>false</c></returns>
        bool IsRegistered<TService>(string implementationKey = null);

        /// <summary>
        /// Resolves the specified service
        /// </summary>
        /// <param name="serviceType">Type of the service to be resolved</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType"/></param>
        /// <returns>Untyped instance of the specified <paramref name="serviceType"/></returns>
        object Resolve(Type serviceType, string implementationKey = null);

        /// <summary>
        /// Resolves the specified service
        /// </summary>
        /// <typeparam name="TService">Type of the service to be resolved</typeparam>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <typeparamref name="TService"/></param>
        /// <returns>Strong typed instance of the specified <paramref name="serviceType"/></returns>
        TService Resolve<TService>(string implementationKey = null);

        /// <summary>
        /// Tries to resolve the specified service
        /// </summary>
        /// <param name="serviceType">Type of the service to be resolved</param>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <paramref name="serviceType"/></param>
        /// <param name="serviceInstance">Out parameter to store a resolved untyped service instance in</param>
        /// <returns><c>true</c> if the specifed service could be reolved successfully; otherwise <c>false</c></returns>
        bool TryResolve(Type serviceType, out object serviceInstance, string implementationKey = null);

        /// <summary>
        /// Tries to resolve the specified service
        /// </summary>
        /// <typeparam name="TService">Type of the service to be resolved</typeparam>
        /// <param name="implementationKey">An optional key to specify a specific implementation in case of multiple registrations of the specified <typeparamref name="TService"/></param>
        /// <param name="serviceInstance">Out parameter to store a resolved strong typed service instance in</param>
        /// <returns><c>true</c> if the specifed service could be reolved successfully; otherwise <c>false</c></returns>
        bool TryResolve<TService>(out TService serviceInstance, string implementationKey = null);
    }
}
