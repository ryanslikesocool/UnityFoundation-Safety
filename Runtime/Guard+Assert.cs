using UnityEngine;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using System;

namespace Foundation {
	public static partial class Guard {
		/// <summary>
		/// Performs a traditional C-style assert.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Assert(Func<bool> condition)
			=> Assert(condition, () => ASSERTION_FAILED);

		/// <summary>
		/// Performs a traditional C-style assert.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Assert(bool condition)
			=> Assert(() => condition);

		/// <summary>
		/// Performs a traditional C-style assert with a message.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Assert(Func<bool> condition, Func<string> message) {
			if (!condition()) {
				Debug.unityLogger.Log(LogType.Assert, message());
			}
		}

		/// <summary>
		/// Performs a traditional C-style assert with a message.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Assert(bool condition, Func<string> message)
			=> Assert(() => condition, message);

		// MARK: - Throw

		public static partial class Throw {
			/// <summary>
			/// Performs a traditional C-style assert and throws an exception on failure.
			/// </summary>
			/// <param name="condition">The condition to test.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void Assert(Func<bool> condition)
				=> Assert(condition, () => ASSERTION_FAILED);

			/// <summary>
			/// Performs a traditional C-style assert and throws an exception on failure.
			/// </summary>
			/// <param name="condition">The condition to test.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void Assert(bool condition)
				=> Assert(() => condition);

			/// <summary>
			/// Performs a traditional C-style assert with a message and throws an exception on failure.
			/// </summary>
			/// <param name="condition">The condition to test.</param>
			/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void Assert(Func<bool> condition, Func<string> message) {
				if (!condition()) {
					throw new AssertionFailedException(message());
				}
			}

			/// <summary>
			/// Performs a traditional C-style assert with a message and throws an exception on failure.
			/// </summary>
			/// <param name="condition">The condition to test.</param>
			/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
			/// <exception cref="AssertionFailedException">Thrown upon failure.</exception>
			[MethodImpl(AggressiveInlining)]
			public static void Assert(bool condition, Func<string> message)
				=> Assert(() => condition, message);
		}

		// MARK: - Constants

		private const string ASSERTION_FAILED = "Assertion failed.";
	}
}