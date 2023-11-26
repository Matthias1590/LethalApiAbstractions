using System.Linq;
using System.Reflection;

namespace LethalCompany.Extensions
{
	public static class ConstructorInfoExtensions
	{
		public static bool CanPassArguments(this ConstructorInfo constructor, params object[] arguments)
		{
			return constructor
				.GetParameters()
				.Select(p => p.ParameterType)
				.Zip(arguments, (paramType, arg) => (paramType, argType: arg.GetType()))
				.All(p => p.paramType.IsAssignableFrom(p.argType));
		}
	}
}
