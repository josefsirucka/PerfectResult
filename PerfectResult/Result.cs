// <copyright file="Result.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Base class for a result of an operation.
/// </summary>
/// <typeparam name="T">Type of the result.</typeparam>
public abstract class Result : IResult
{
    /// <inheritdoc/>
    public abstract bool Success { get; }

    /// <summary>
    /// Gets the return message of the operation.
    /// </summary>
    public abstract string Message { get; }

    /// <summary>
    /// Gets the exception thrown during the operation.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when attempting to access Exception of a successful operation.</exception>
    public abstract Exception? Exception { get; }
}