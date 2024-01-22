// <copyright file="FailureResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

[TestFixture]
public class FailureResultTests
{
    [Test]
    public void FailureResult_WithMessageAndException_ShouldSetProperties()
    {
        var exception = new Exception("Test exception");
        var result = new FailureResult("Operation failed", exception);
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
    }

    [Test]
    public void FailureResult_WithMessageAndNoException_ShouldSetDefaultException()
    {
        var result = new FailureResult("Operation failed");
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
        });
        Assert.IsNotNull(result.Exception);
        Assert.That(result.Exception.Message, Is.EqualTo("There was no exception thrown"));
    }
}