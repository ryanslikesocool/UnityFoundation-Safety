using System;
using System.Runtime.CompilerServices;

namespace Foundation {
	public static partial class Guard {
		/// <summary>
		/// Perform a null-coalescing operation.
		/// 	<para>
		/// 	This function is useful when wanting to do a null-coalescing operation on a <see cref="UnityEngine.Object"/>.
		/// 	</para>
		/// </summary>
		/// <param name="source">The object to perform a null-coalescing operation on.</param>
		/// <param name="fallback">A closure returning a fallback value if <see paramref="source"/> is <see langword="null"/>.</param>
		/// <returns>The <see paramref="source"/> object if it was not <see langword="null"/>; the result of <see paramref="fallback"/> otherwise.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Result NullCoalesce<Result>(this Result source, Func<Result> fallback) where Result : class {
			if (source == null) {
				return fallback();
			} else {
				return source;
			}
		}
	}
}