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
			=> Assert(condition, () => "Assertion failed");

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
	}
}