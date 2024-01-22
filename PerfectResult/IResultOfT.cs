// <copyright file="IResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult;

/// <summary>
/// Interface that extends the origin one with T value.
/// </summary>
/// <typeparam name="T">Type of Value object.</typeparam>
public interface IResult<T> : IResult
{
    /// <summary>
    /// Gets a value of the object that is type of T.
    /// </summary>
    /// <value>Value or object that is returned.</value>
    T Value { get; }
}