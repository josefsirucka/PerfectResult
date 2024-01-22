// <copyright file="IResultBase.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Interface for a result of an operation.
/// </summary>
public interface IResult
{
    /// <summary>
    /// Gets a value indicating whether the operation was successful.
    /// </summary>
    bool Success { get; }

    /// <summary>
    /// Gets the message of the operation.
    /// </summary>
    string Message { get; }

    /// <summary>
    /// Gets the exception thrown during the operation.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when attempting to access Exception of a successful operation.</exception>
    Exception? Exception { get; }

    /// <summary>
    /// Creates a successful result with a value.
    /// </summary>
    /// <typeparam name="T">Type of the result.</typeparam>
    /// <param name="value">The result value.</param>
    /// <param name="successMessage">(Optional) The success message value.</param>
    /// <returns>A successful Result.</returns>
    public static IResult<T> SuccessResult<T>(T value, string? successMessage = null)
    {
        return new SuccessResult<T>(value, successMessage);
    }

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    /// <typeparam name="T">Type of the result.</typeparam>
    /// <param name="errorMessage">The error message.</param>
    /// <param name="exception">The exception thrown during the operation.</param>
    /// <returns>A failed Result.</returns>
    public static IResult<T> FailureResult<T>(string errorMessage, Exception? exception = null)
    {
        return new FailureResult<T>(errorMessage, exception);
    }

    /// <summary>
    /// Creates a successful result for an operation that does not return a value (the return type is IResult&lt;void&gt;).
    /// </summary>
    /// <param name="successMessage">The success message.</param>
    /// <returns>A successful Result.</returns>
    public static IResult SuccessResult(string? successMessage = null)
    {
        return new SuccessResult(successMessage);
    }

    /// <summary>
    /// Creates a failures result for an operation that does not return a value (the return type is IResult &lt; Void &gt;).
    /// </summary>
    /// <param name="errorMessage">The error message.</param>
    /// <param name="exception">The exception thrown during the operation.</param>
    /// <returns>A failed Result.</returns>
    public static IResult FailureResult(string errorMessage, Exception? exception = null)
    {
        return new FailureResult(errorMessage, exception);
    }
}