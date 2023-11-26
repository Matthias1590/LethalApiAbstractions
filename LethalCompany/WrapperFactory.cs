using LethalCompany.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LethalCompany
{
	public static class WrapperFactory
	{
		// Should probably use weak references
		private static readonly Dictionary<object, object> _wrappedObjects = new Dictionary<object, object>();

		public static TInterface Wrap<TInterface>(object gameObject)
			where TInterface : class
		{
			if (gameObject == null)
			{
				return null;
			}

			return (TInterface) _wrappedObjects.GetOrCalculate(gameObject, () =>
			{
				return TypeMap.GetWrapperByInterface(typeof(TInterface))
					.GetConstructors()
					.Where(c => c.CanPassArguments(gameObject))
					.Single()
					.Invoke(new object[] { gameObject });
			});
		}
	}
}
