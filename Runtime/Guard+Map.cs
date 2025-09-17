using System;
using System.Runtime.CompilerServices;

namespace Foundation {
	public static partial class Guard {
//		/// <summary>
//		/// Evaluates the given <see paramref="transform"/> when the given <see paramref="source"/> is not <see langword="null"/>, passing the unwrapped value as a parameter.
//		/// </summary>
//		/// <param name="source">The object to transform.</param>
//		/// <param name="transform">A closure that takes the unwrapped value of the given <see paramref="source"/>.</param>
//		/// <returns>The result of the given <see paramref="transform"/> closure. If the <see paramref="source"/> is <see langword="null"/>, returns <see langword="null"/>.</returns>
//		[MethodImpl(MethodImplOptions.AggressiveInlining)]
//		public static Result Map<Source, Result>(this Source source, Func<Source, Result> transform)
//			where Source : class
//			where Result : class
//		{
//			if (source == null) {
//				return null;
//			} else {
//				return transform(source);
//			}
//		}
//
//		/// <summary>
//		/// Evaluates the given <see paramref="transform"/> when the given <see paramref="source"/> is not <see langword="null"/>, passing the unwrapped value as a parameter.
//		/// </summary>
//		/// <param name="source">The object to transform.</param>
//		/// <param name="transform">A closure that takes the unwrapped value of the given <see paramref="source"/>.</param>
//		/// <returns>The result of the given <see paramref="transform"/> closure. If the <see paramref="source"/> is <see langword="null"/>, returns <see langword="null"/>.</returns>
//		[MethodImpl(MethodImplOptions.AggressiveInlining)]
//		public static Result? Map<Source, Result>(this Source source, Func<Source, Result> transform)
//			where Source : class
//			where Result : struct
//		{
//			if (source == null) {
//				return null;
//			} else {
//				return transform(source);
//			}
//		}
	}
}