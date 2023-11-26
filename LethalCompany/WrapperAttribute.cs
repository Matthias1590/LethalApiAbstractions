using System;

namespace LethalCompany
{
	[AttributeUsage(AttributeTargets.Class)]
	public class WrapperAttribute : Attribute
	{
        public Type UnderlyingType { get; }

        public WrapperAttribute(Type underlyingType)
        {
			UnderlyingType = underlyingType;
		}
    }
}
