using System;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Discord.Addons.AspNetDI
{
    public class AspNetDependencyMap : IDependencyMap
    {
		private IServiceProvider _provider;

		public AspNetDependencyMap(IServiceProvider provider)
		{
			_provider = provider;
		}

        public void Add<T>(T obj)
        {
            throw new NotSupportedException("Adding to the dependency map is not supported.");
        }

        public object Get(Type t)
        {
            return _provider.GetRequiredService(t);
        }

        public T Get<T>()
        {
            return _provider.GetRequiredService<T>();
        }

        public bool TryGet(Type t, out object result)
        {
            result = _provider.GetService(t);

            return (result != null);
        }

        public bool TryGet<T>(out T result)
        {
            result = _provider.GetService<T>();

            return (result != null);
        }
    }
}