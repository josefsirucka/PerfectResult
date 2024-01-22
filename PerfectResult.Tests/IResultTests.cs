// <copyright file="IResultTests.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;
[TestFixture]
public class IResultFactoryMethodTests
{
    // Test for non-generic SuccessResult
    [Test]
    public void SuccessResultFactoryMethod_NonGeneric_ShouldReturnSuccessResult()
    {
        var result = IResult.SuccessResult("Operation successful");
        Assert.That(result, Is.InstanceOf<SuccessResult>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.True);
            Assert.That(result.Message, Is.EqualTo("Operation successful"));
        });
    }

    // Test for generic SuccessResult
    [Test]
    public void SuccessResultFactoryMethod_Generic_ShouldReturnSuccessResult()
    {
        var result = IResult.SuccessResult(123, "Operation successful");
        Assert.That(result, Is.InstanceOf<SuccessResult<int>>());
        Assert.That(result.Success, Is.True);
        Assert.Multiple(() =>
        {
            Assert.That(result.Value, Is.EqualTo(123));
            Assert.That(result.Message, Is.EqualTo("Operation successful"));
        });
    }

    // Test for non-generic FailureResult
    [Test]
    public void FailureResultFactoryMethod_NonGeneric_ShouldReturnFailureResult()
    {
        var exception = new Exception("Test exception");
        var result = IResult.FailureResult("Operation failed", exception);
        Assert.That(result, Is.InstanceOf<FailureResult>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
    }

    // Test for generic FailureResult
    [Test]
    public void FailureResultFactoryMethod_Generic_ShouldReturnFailureResult()
    {
        var exception = new Exception("Test exception");
        var result = IResult.FailureResult<int>("Operation failed", exception);
        Assert.That(result, Is.InstanceOf<FailureResult<int>>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.False);
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
        Assert.Throws<InvalidOperationException>(() => { var value = result.Value; });
    }
}