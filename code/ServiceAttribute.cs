using System;
using System.Collections.Generic;
using System.Linq;

namespace Sitecore.Foundation.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        public ServiceAttribute()
        {
        }

        public ServiceAttribute(params Type[] serviceTypes)
        {
            ServiceTypes = serviceTypes;
        }

        public Lifetime Lifetime { get; set; } = Lifetime.Singleton;

        public Type ServiceType
        {
            get { return (ServiceTypes ?? Enumerable.Empty<Type>()).FirstOrDefault(); }
            set { ServiceTypes = new[] { value }; }
        }

        public IEnumerable<Type> ServiceTypes { get; set; }
    }
}
