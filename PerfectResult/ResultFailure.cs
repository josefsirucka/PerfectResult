// <copyright file="ResultFailure.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Represents a failed result of an operation.
/// </summary>
/// <typeparam name="T">Type of the result.</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="FailureResult{T}"/> class.
/// </remarks>
/// <param name="errorMessage">Error message.</param>
/// <param name="exception">Exception to store.</param>
public sealed class FailureResult<T>(string errorMessage, Exception? exception = null) : Result<T>
{

    /// <inheritdoc/>
    public override bool Success => false;

    /// <inheritdoc/>
    /// <summary>
    /// Gets the value of a failed operation. Always throws an InvalidOperationException when accessed.
    /// </summary>
    public override T Value => throw new InvalidOperationException("Cannot get value from a failed operation - with error message: " + Message);

    /// <inheritdoc/>
    public override string Message { get; } = errorMessage;

    /// <inheritdoc/>
    public override Exception? Exception { get; } = exception;
}