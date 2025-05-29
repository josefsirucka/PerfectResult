// <copyright file="SuccessResultTemplates.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult.Tests;

/// <summary>
/// Provides templates for creating result instances used in tests.
/// </summary>
public class FailureResultTemplates
{
    private static readonly Exception _exception = new("This is a test exception");

    /// <summary>
    /// Creates a failure result without a specified message.
    /// </summary>
    /// <returns>IPResult - FailureResult instance.</returns>
    public static IPResult GetFailureResultEmptyMessage()
    {
        return IPResult.FailureResult();
    }

    /// <summary>
    /// Creates a failure result without a specified message.
    /// </summary>
    /// <returns>IPResult - FailureResult instance.</returns>
    public static IPResult GetFailureResultCustomeMessage()
    {
        return IPResult.FailureResult("Custom failure message.");
    }

    public static IPResult GetFailureResultWithExceptionEmptyMessage()
    {

        return IPResult.FailureResult(exception: _exception);
    }

    public static IPResult GetFailureResultWithValueCustomMessage()
    {
        return IPResult.FailureResult("Custom failure message.", exception: _exception);

    }
}