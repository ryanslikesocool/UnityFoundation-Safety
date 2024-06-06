using UnityEngine;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Foundation {
	public static partial class Guard {
		[MethodImpl(AggressiveInlining)]
		public static void DestroySafe(this Object obj) {
			if (obj == null) {
				return;
			}

#if UNITY_EDITOR
			if (Application.isPlaying) {
				Object.Destroy(obj);
			} else {
				Object.DestroyImmediate(obj);
			}
#else
            Object.Destroy(obj);
#endif
		}
	}
}