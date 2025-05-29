// <copyright file="MatchingSuccessTests.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult.Tests;

/// <summary>
/// Tests for the matching of success results in the PerfectResult library.
/// </summary>
[TestFixture]
public class MatchingSuccessTests
{
    /// <summary>
    /// Tests that a success result can be matched correctly.
    /// </summary>
    [Test]
    public void MatchingGetSuccessResultEmptyMessage()
    {
        SuccessResultTemplates.GetSuccessResultEmptyMessage().Match(
            onSuccess: _ => Assert.Pass("Matched success result with empty message."),
            onFailure: _ => Assert.Fail("Should not match failure result.")
        );

        IPResult sucessResult = SuccessResultTemplates.GetSuccessResultEmptyMessage().Match(
            onSuccess => DoSomethingAndReturnResult(onSuccess).Match(
                onSuccess: _ => Assert.Pass("Matched success result with empty message."),
                onFailure: _ => Assert.Fail("Should not match failure result.")
            ),
            onFailure => LogFailureAndReturnNewResult(onFailure).Match(
                onSuccess: _ => Assert.Fail("Should not match success result."),
                onFailure: _ => Assert.Pass("Matched failure result.")
            )
        );

        IPResult failingResult = FailureResultTemplates.GetFailureResultWithExceptionEmptyMessage().Match(
            onSuccess: DoSomethingAndReturnResult,
            onFailure: LogFailureAndReturnNewResult
        );
    }

    private static IPResult DoSomethingAndReturnResult(ISuccess success)
    {
        return IPResult.SuccessResult("Processed successfully with empty message.");
    }

    private static IPResult LogFailureAndReturnNewResult(IFailure failure)
    {
        return IPResult.FailureResult("Failed to process due to: " + failure.Message);
    }
}
