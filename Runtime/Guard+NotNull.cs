using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using System;

namespace Foundation {
	public static partial class Guard {
		/// <summary>
		/// Assert that an object is not <see langword="null"/> using the <c>!=</c> operator.
		/// </summary>
		/// <param name="obj">The object to check.</param>
		/// <returns><see langword="true"/> if the object was not <see langword="null"/>; <see langword="false"/> otherwise.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool NotNull<T>(Func<T> obj) where T : class {
			if (obj != null) {
				return true;
			} else {
				Assert(obj != null, () => "The object was null.");
				return false;
			}
		}

		/// <summary>
		/// Assert that an object is not <see langword="null"/> using the <c>!=</c> operator.
		/// </summary>
		/// <param name="obj">The object to check.</param>
		/// <returns><see langword="true"/> if the object was not <see langword="null"/>; <see langword="false"/> otherwise.</returns>
		[MethodImpl(AggressiveInlining)]
		public static bool NotNull<T>(T obj) where T : class
			=> NotNull(() => obj);
	}
}