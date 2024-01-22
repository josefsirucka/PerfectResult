// <copyright file="FailureResultOfT.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

[TestFixture]
public class FailureResultGenericTests
{
    [Test]
    public void FailureResultGeneric_WithMessageAndException_ShouldSetProperties()
    {
        var exception = new Exception("Test exception");
        var result = new FailureResult<int>("Operation failed", exception);
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
    }

    [Test]
    public void FailureResultGeneric_ShouldThrowInvalidOperationExceptionWhenAccessingValue()
    {
        var result = new FailureResult<int>("Operation failed", new Exception());
        Assert.Throws<InvalidOperationException>(() => { var value = result.Value; });
    }
}