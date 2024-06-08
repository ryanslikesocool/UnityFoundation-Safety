using System;

namespace Foundation {
	public sealed class PreconditionFailedException : Exception {
		public PreconditionFailedException()
			: base(MESSAGE_STANDARD) { }

		public PreconditionFailedException(string message)
			: base(string.Format(MESSAGE_FORMAT, message)) { }

		// MARK: - Constants

		private const string MESSAGE_STANDARD = "Precondition failed.";
		private const string MESSAGE_FORMAT = "Precondition failed: {0}";
	}
}