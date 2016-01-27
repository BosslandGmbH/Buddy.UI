using System;
using System.Diagnostics;

namespace Buddy.UI.Core
{
	public static class Requires
	{
		/// <summary>
		///     Throws a <see cref="ArgumentNullException" /> if the specified parameter's value is null.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value">The value.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		[DebuggerStepThrough]
		public static void NotNull<T>(T value, string parameterName) where T : class
		{
			if (value == null)
				FailArgumentNull(parameterName);
		}

		/// <summary>
		///     Throws a <see cref="ArgumentNullException" /> if the specified string is either null or empty.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		[DebuggerStepThrough]
		public static void NotNullOrEmpty(string value, string parameterName)
		{
			if (string.IsNullOrEmpty(value))
				FailArgumentNull(parameterName);
		}

		/// <summary>
		///     Throws a <see cref="ArgumentNullException" /> if the specified string is either null or a whitespace.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		[DebuggerStepThrough]
		public static void NotNullOrWhitespace(string value, string parameterName)
		{
			if (string.IsNullOrWhiteSpace(value))
				FailArgumentNull(parameterName);
		}

		/// <summary>
		///     Throws a <see cref="ArgumentException" /> if the specified condition is not met.
		/// </summary>
		/// <param name="condition">The condition that should evaluate to true for it to be valid.</param>
		/// <param name="parameterName">Name of the parameter.</param>
		/// <exception cref="System.ArgumentException"></exception>
		[DebuggerStepThrough]
		public static void Condition(bool condition, string parameterName)
		{
			if (!condition)
				throw new ArgumentException();
		}

		private static void FailArgumentNull(string parameterName)
		{
			throw new ArgumentNullException(parameterName);
		}
	}
}
