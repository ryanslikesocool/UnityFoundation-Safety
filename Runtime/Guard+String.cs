namespace Foundation {
	public static partial class Guard {
		public static bool IsNullOrEmptyOrWhiteSpace(this string str)
			=> string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
	}
}