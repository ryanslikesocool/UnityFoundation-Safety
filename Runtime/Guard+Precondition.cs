using UnityEngine;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;
using System;

namespace Foundation {
	public static partial class Guard {
		/// <summary>
		/// Checks a necessary condition for making forward progress.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Precondition(Func<bool> condition)
			=> Precondition(condition, () => "Precondition failed.");

		/// <summary>
		/// Checks a necessary condition for making forward progress.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Precondition(bool condition)
			=> Precondition(() => condition);

		/// <summary>
		/// Checks a necessary condition for making forward progress.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Precondition(Func<bool> condition, Func<string> message) {
			if (!condition()) {
				Debug.unityLogger.Log(LogType.Assert, message());
			}
		}

		/// <summary>
		/// Checks a necessary condition for making forward progress.
		/// </summary>
		/// <param name="condition">The condition to test.</param>
		/// <param name="message">A string to log to the console if <paramref name="condition"/> is evaluated to <see langword="false"/>.</param>
		[MethodImpl(AggressiveInlining)]
		public static void Precondition(bool condition, Func<string> message)
			=> Precondition(() => condition, message);
	}
}