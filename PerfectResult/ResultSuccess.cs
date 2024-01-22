// <copyright file="ResultSuccess.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Represents a successful result of an operation.
/// </summary>
/// <typeparam name="T">Type of the result.</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="SuccessResult{T}"/> class.
/// </remarks>
/// <param name="value">Value/object to be returned.</param>
/// <param name="successMessage">Success message to be returned.</param>
public sealed class SuccessResult<T>(T value, string? successMessage) : Result<T>
{

    /// <inheritdoc/>
    public override bool Success => true;

    /// <inheritdoc/>
    /// <summary>
    /// Gets the value of a successful operation.
    /// </summary>
    public override T Value { get; } = value;

    /// <inheritdoc/>
    public override string Message { get; } = successMessage ?? "Operation was successfull.";

    /// <inheritdoc/>
    public override Exception? Exception => throw new InvalidOperationException("No exception for a successful operation.");
}