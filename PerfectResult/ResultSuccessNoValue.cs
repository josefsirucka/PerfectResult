// <copyright file="ResultSuccessNoValue.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Represents a successful result of an operation that does not return a value.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="SuccessResult"/> class.
/// </remarks>
/// <param name="successMessage">The success message.</param>
public sealed class SuccessResult(string? successMessage) : Result
{

    /// <inheritdoc/>
    public override bool Success => true;

    /// <inheritdoc/>
    public override string Message { get; } = successMessage ?? "Operation was successfull.";

    /// <inheritdoc/>
    public override Exception? Exception => throw new InvalidOperationException("No exception for a successful operation.");
}