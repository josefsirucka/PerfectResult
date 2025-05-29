// <copyright file="SuccessTests.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

/// <summary>
/// This class contains tests for the IResult factory methods.
/// These are the main happy scenario tests for the factory methods.
/// </summary>
[TestFixture]
public class SuccessTests
{
    [Test]
    public void GetSuccessResultEmptyMessage()
    {
        IPResult result = SuccessResultTemplates.GetSuccessResultEmptyMessage();

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Success>());
            Assert.That(result.Message, Is.EqualTo("Operation successful."));
        });
    }

    [Test]
    public void GetSuccessResultCustomeMessage()
    {
        IPResult result = SuccessResultTemplates.GetSuccessResultCustomeMessage();

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Success>());
            Assert.That(result.Message, Is.EqualTo("Custom success message"));
        });
    }

    [Test]
    public void GetSuccessResultWithValueEmptyMessage()
    {
        IPResult<int> result = SuccessResultTemplates.GetSuccessResultWithValueEmptyMessage();

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Success<int>>());
            Assert.That(result.Value, Is.EqualTo(2025));
            Assert.That(result.Message, Is.EqualTo("Operation successful."));
        });
    }

    [Test]
    public void GetSuccessResultWithValueCustomMessage()
    {
        IPResult<int> result = SuccessResultTemplates.GetSuccessResultWithValueCustomMessage();

        Assert.Multiple(() =>
        {
            Assert.That(result, Is.InstanceOf<Success<int>>());
            Assert.That(result.Value, Is.EqualTo(2025));
            Assert.That(result.Message, Is.EqualTo("Custom success message with value."));
        });
    }






/*

    // Test for non-generic SuccessResult - with no message.
    [Test]
    public void SuccessResultFactoryMethod_NonGeneric_ShouldReturnSuccessResult()
    {
        int expectedValue = 0;

        var result = MethodReturningSuccessfullOperation()
            .Match(
                onSuccess => expectedValue = 2,
                onFailure => expectedValue = -1
            );

        Assert.That(result, Is.InstanceOf<SuccessResult>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Message, Is.EqualTo("Operation successful"));
        });
    }

    // Test for generic SuccessResult
    [Test]
    public void SuccessResultFactoryMethod_Generic_ShouldReturnSuccessResult()
    {
        SuccessResult result = IResult.SuccessResult(123, "Operation successful");
        Assert.That(result, Is.InstanceOf<SuccessResult<int>>());
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
        Exception exception = new Exception("Test exception");
        var result = IResult.FailureResult("Operation failed", exception);
        Assert.That(result, Is.InstanceOf<FailureResult>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
    }

    // Test for generic FailureResult
    [Test]
    public void FailureResultFactoryMethod_Generic_ShouldReturnFailureResult()
    {
        Exception exception = new Exception("Test exception");
        var result = IResult.FailureResult<int>("Operation failed", exception);
        Assert.That(result, Is.InstanceOf<FailureResult<int>>());
        Assert.Multiple(() =>
        {
            Assert.That(result.Message, Is.EqualTo("Operation failed"));
            Assert.That(result.Exception, Is.EqualTo(exception));
        });
        Assert.Throws<InvalidOperationException>(() => { var value = result.Value; });
    }
    */
}