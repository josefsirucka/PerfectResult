// <copyright file="PResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult;

/// <summary>
/// Base class for results in the PerfectResult library.
/// </summary>
public abstract class PResult : IPResult
{
    /// <summary>
    /// Gets the return message of the operation.
    /// </summary>
    public abstract string Message { get; }
}
