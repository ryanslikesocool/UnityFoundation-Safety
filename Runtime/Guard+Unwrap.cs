using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Foundation {
	public static partial class Guard {
		[MethodImpl(AggressiveInlining)]
		public static bool TryGetValue<T>(this T? source, out T value) where T : struct {
			value = source.GetValueOrDefault();
			return source.HasValue;
		}

		[MethodImpl(AggressiveInlining)]
		public static bool TryGetValue<T>(this T source, out T value) where T : class {
			if (source is not null) {
				value = source;
				return true;
			} else {
				value = null;
				return false;
			}
		}
	}
}