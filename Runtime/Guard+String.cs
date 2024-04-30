namespace Foundation {
	public static partial class Guard {
		public static bool IsNullEmptyOrWhiteSpace(this string str)
			=> string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
	}
}