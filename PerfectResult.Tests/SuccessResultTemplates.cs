// <copyright file="SuccessResultTemplates.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult.Tests;

/// <summary>
/// Provides templates for creating result instances used in tests.
/// </summary>
public class SuccessResultTemplates
{
    /// <summary>
    /// Creates a success result without a specified message.
    /// </summary>
    /// <returns>IPResult - SuccessResult instance.</returns>
    public static IPResult GetSuccessResultEmptyMessage()
    {
        return IPResult.SuccessResult();
    }

    /// <summary>
    /// Creates a failure result without a specified message.
    /// </summary>
    /// <returns>IPResult - SuccessResult instance.</returns>
    public static IPResult GetSuccessResultCustomeMessage()
    {
        return IPResult.SuccessResult("Custom success message");
    }

    public static IPResult<int> GetSuccessResultWithValueEmptyMessage()
    {
        return IPResult.SuccessResult(2025);
    }

    public static IPResult<int> GetSuccessResultWithValueCustomMessage()
    {
        return IPResult.SuccessResult(2025, "Custom success message with value.");
    }
}