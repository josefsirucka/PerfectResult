// <copyright file="IPResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Interface for a result of an operation.
/// </summary>
public interface IPResult
{
    /// <summary>
    /// Creates a successful result for an operation that does not return a value (the return type is Success).
    /// </summary>
    /// <param name="successMessage">The success message.</param>
    /// <returns>A successful Result.</returns>
    public static Success SuccessResult(string? successMessage = null)
    {
        return new Success(successMessage);
    }

    /// <summary>
    /// Creates a successful result for an operation that returns a value.
    /// </summary>
    /// <param name="successMessage">The success message.</param>
    /// <returns>A successful Result.</returns>
    public static Success<T> SuccessResult<T>(T value, string? successMessage = null)
    {
        return new Success<T>(value, successMessage);
    }

    /// <summary>
    /// Creates a failure result for an operation that does not return a value (the return type is IPResult&lt;void&gt;).
    /// </summary>
    /// <param name="failureMessage"></param>
    /// <param name="exception"></param>
    /// <returns></returns>
    public static Failure FailureResult(string? failureMessage = null, Exception? exception = null)
    {
        return new Failure(failureMessage, exception);
    }

    /// <summary>
    /// Gets a message.
    /// </summary>
    string Message { get; }

    // void Match<T>(Action<T> onSuccess, Action<Exception> onFailure);

    // object Result(Action onSuccess, Action onFailure);
}