// <copyright file="ResultFailureNoValue.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Represents a failed result of an operation.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="FailureResult"/> class.
/// </remarks>
/// <param name="successMessage">The failure message.</param>
/// <param name="exception">Exeption if any.</param>
public sealed class FailureResult(string successMessage, Exception? exception = null) : Result
{

    /// <inheritdoc/>
    public override bool Success => false;

    /// <inheritdoc/>
    public override string Message { get; } = successMessage;

    /// <inheritdoc/>
    public override Exception? Exception { get; } = exception ?? new Exception("There was no exception thrown");
}