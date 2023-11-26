using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LethalCompany
{
	public static class TypeMap
	{
		private readonly static Dictionary<Type, Type> _typeMap = new Dictionary<Type, Type>();

		public static void RegisterImplementationAssembly(Assembly implementationAssembly)
		{
			var wrapperTypes = implementationAssembly
				.GetTypes()
				.Where(t => t.GetCustomAttribute<WrapperAttribute>() != null);

			foreach (var wrapperType in wrapperTypes)
			{
				_typeMap.Add(wrapperType, wrapperType.GetCustomAttribute<WrapperAttribute>().UnderlyingType);
			}
		}

		public static Type GetWrappedType(Type wrapperType)
		{
			return _typeMap[wrapperType];
		}

		public static Type GetWrapperByInterface(Type wrapperInterface)
		{
			return _typeMap
				.Where(p => wrapperInterface.IsAssignableFrom(p.Key))
				.Select(p => p.Value)
				.Single();
		}

		public static Type GetUnderlyingTypeByInterface<TInterface>()
			where TInterface : class
		{
			return GetWrappedType(GetWrapperByInterface(typeof(TInterface)));
		}
	}
}
