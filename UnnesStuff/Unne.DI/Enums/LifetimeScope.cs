namespace Unne.DI
{
    /// <summary>
    /// Enumeration of supported lifetime scopes of resolved service implemenations
    /// </summary>
    public enum LifetimeScope
    {
        /// <summary>
        /// Create a new instance whenever a service resolution is requested
        /// </summary>
        PerDependency = 1,
        /// <summary>
        /// Create a singleton instance when a service resolution is requested the first time 
        /// and afterwards always return the same instance
        /// </summary>
        Singleton = 2
    }
}
