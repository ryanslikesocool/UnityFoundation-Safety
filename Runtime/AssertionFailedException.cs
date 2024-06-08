using System;

namespace Foundation {
	public sealed class AssertionFailedException : Exception {
		public AssertionFailedException()
			: base(MESSAGE_STANDARD) { }

		public AssertionFailedException(string message)
			: base(string.Format(MESSAGE_FORMAT, message)) { }

		// MARK: - Constants

		private const string MESSAGE_STANDARD = "Assertion failed.";
		private const string MESSAGE_FORMAT = "Assertion failed: {0}";
	}
}