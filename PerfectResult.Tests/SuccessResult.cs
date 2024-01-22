// <copyright file="SuccessResult.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

[TestFixture]
public class SuccessResultTests
{
    [Test]
    public void SuccessResult_WithMessage_ShouldSetSuccessTrueAndMessage()
    {
        var result = new SuccessResult("Operation successful");
        Assert.Multiple(() =>
        {
            Assert.That(result.Success, Is.True);
            Assert.That(result.Message, Is.EqualTo("Operation successful"));
        });
    }

    [Test]
    public void SuccessResult_WithNullMessage_ShouldSetDefaultMessage()
    {
        var result = new SuccessResult(null);
        Assert.That(result.Message, Is.EqualTo("Operation was successfull."));
    }

    [Test]
    public void SuccessResult_ShouldThrowInvalidOperationExceptionWhenAccessingException()
    {
        var result = new SuccessResult("Operation successful");
        Assert.Throws<InvalidOperationException>(() => { var ex = result.Exception; });
    }
}