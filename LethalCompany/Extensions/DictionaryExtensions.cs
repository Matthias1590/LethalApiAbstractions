using System;
using System.Collections.Generic;

namespace LethalCompany.Extensions
{
	public static  class DictionaryExtensions
	{
		public static TValue GetOrCalculate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> calculate)
		{
			if (!dictionary.TryGetValue(key, out var value))
			{
				value = calculate();

				dictionary[key] = value;
			}

			return value;
		}
	}
}
