using UnityEngine;

namespace LethalCompany.Extensions
{
	public static class GameObjectExtensions
	{
		public static TComponentInterface GetWrappedComponent<TComponentInterface>(this GameObject gameObject)
			where TComponentInterface : class
		{
			var underlyingType = TypeMap.GetUnderlyingTypeByInterface<TComponentInterface>();
			var underlyingComponent = gameObject.GetComponent(underlyingType);
			var wrappedComponent = WrapperFactory.Wrap<TComponentInterface>(underlyingComponent);

			return wrappedComponent;
		}
	}
}
