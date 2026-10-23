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
		public static TResult NullCoalesce<TResult>(this TResult source, Func<TResult> fallback) where TResult : class {
			if (source == null) {
				return fallback();
			} else {
				return source;
			}
		}

		/// <summary>
		/// Perform a null-propagation operation.
		/// 	<para>
		/// 	This function is useful when wanting to do a null-propagation operation on a <see cref="UnityEngine.Object"/>.
		/// 	</para>
		/// </summary>
		/// <param name="source">The object to perform a null-propagation operation on.</param>
		/// <param name="transform">A closure transforming <see paramref="source"/> if it is not <see langword="null"/>.</param>
		/// <param name="fallback">A closure returning a fallback value if <see paramref="source"/> is <see langword="null"/>.</param>
		/// <returns>The result of <see paramref="transform"/> if <see paramref="source"/> was not <see langword="null"/>; the result of <see paramref="fallback"/> otherwise.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TResult NullPropagate<TTarget, TResult>(this TTarget target, Func<TTarget, TResult> transform, Func<TResult> fallback) where TTarget : class {
			if (target == null) {
				return fallback();
			} else {
				return transform(target);
			}
		}
	}
}