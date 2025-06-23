// <copyright file="FailureResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

/// <summary>
/// This class contains tests for the failing IResult factory methods.
/// These are the main un-happy scenario tests for the factory methods.
/// </summary>
[TestFixture]
public class FailureTests
{
    [Test]
    public void GetFailureResultEmptyMessage()
    {
        IPResult result = FailureResultTemplates.GetFailureResultEmptyMessage();
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Failure>());
            Assert.That(result.Message, Is.EqualTo("Operation failed."));
        });

        if (result is Failure failure)
        {
            Assert.That(failure.Exception, Is.Not.Null);
            Assert.That(failure.Exception.Message, Is.EqualTo("A failure occurred, but no exception was provided."));
        }
    }

    [Test]
    public void GetFailureResultCustomeMessage()
    {
        IPResult result = FailureResultTemplates.GetFailureResultCustomeMessage();
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Failure>());
            Assert.That(result.Message, Is.EqualTo("Custom failure message."));
        });

        if (result is Failure failure)
        {
            Assert.That(failure.Exception, Is.Not.Null);
            Assert.That(failure.Exception.Message, Is.EqualTo("A failure occurred, but no exception was provided."));
        }
    }

    [Test]
    public void GetFailureResultWithExceptionEmptyMessage()
    {
        IPResult result = FailureResultTemplates.GetFailureResultWithExceptionEmptyMessage();
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Failure>());
            Assert.That(result.Message, Is.EqualTo("Operation failed."));
        });

        if (result is Failure failure)
        {
            Assert.That(failure.Exception, Is.Not.Null);
            Assert.That(failure.Exception.Message, Is.EqualTo("This is a test exception"));
        }
    }

    [Test]
    public void GetFailureResultWithValueCustomMessage()
    {
        IPResult result = FailureResultTemplates.GetFailureResultWithValueCustomMessage();
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Failure>());
            Assert.That(result.Message, Is.EqualTo("Custom failure message."));
        });

        if (result is Failure failure)
        {
            Assert.That(failure.Exception, Is.Not.Null);
            Assert.That(failure.Exception.Message, Is.EqualTo("This is a test exception"));
        }
    }
}
