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
				Assert(obj != null, () => OBJECT_WAS_NULL);
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

		// MARK: - Throw

		public static partial class Throw {
			/// <summary>
			/// Assert that an object is not <see langword="null"/> using the <c>!=</c> operator and throws an exception on failure.
			/// </summary>
			/// <param name="obj">The object to check.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void NotNull<T>(Func<T> obj) where T : class {
				Assert(obj != null, () => OBJECT_WAS_NULL);
			}

			/// <summary>
			/// Assert that an object is not <see langword="null"/> using the <c>!=</c> operator and throws an exception on failure.
			/// </summary>
			/// <param name="obj">The object to check.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void NotNull<T>(T obj) where T : class
				=> NotNull(() => obj);
		}

		// MARK: - Constants

		private const string OBJECT_WAS_NULL = "The object was null.";
	}
}