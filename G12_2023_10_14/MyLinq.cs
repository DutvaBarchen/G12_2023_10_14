namespace G12_2023_10_14.Linq
{
	public static class MyLinq
	{
		public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			if (source == null) throw new ArgumentNullException(nameof(source));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			foreach (var item in source)
			{
				if (predicate(item))
				{
					yield return item;
				}
			}
		}

		public static bool MyAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			if (source == null) throw new ArgumentNullException(nameof(source));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			foreach (var item in source)
			{
				if (predicate(item))
				{
					 return true;
				}
			}

			return false;
		}

		public static bool MyAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			int count = 0;
			if (source == null) throw new ArgumentNullException(nameof(source));
			if (predicate == null) throw new ArgumentNullException(nameof(predicate));

			foreach (var item in source)
			{
				if (predicate(item))
				{
					count++;
				}
			}

			return count == source.Count();
		}

		public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null) throw new ArgumentNullException(nameof(source));
			if (selector == null) throw new ArgumentNullException(nameof(selector));

			var result = new List<TResult>();

            foreach (var item in source)
            {
				result.Add(selector(item));
            }

			return result;
		}
	}
}
