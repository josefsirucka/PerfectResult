// <copyright file="SuccessResultOfT.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 22.01 2024</summary>

namespace PerfectResult.Tests;

[TestFixture]
public class SuccessResultGenericTests
{
    [Test]
    public void SuccessResultGeneric_WithValueAndMessage_ShouldSetProperties()
    {
        var result = new SuccessResult<int>(100, "Operation successful");

        Assert.That(result.Success, Is.True);
        Assert.Multiple(() =>
        {
            Assert.That(result.Value, Is.EqualTo(100));
            Assert.That(result.Message, Is.EqualTo("Operation successful"));
        });
    }

    [Test]
    public void SuccessResultGeneric_WithNullMessage_ShouldSetDefaultMessage()
    {
        var result = new SuccessResult<int>(100, null);

        Assert.That(result.Message, Is.EqualTo("Operation was successfull."));
    }

    [Test]
    public void SuccessResultGeneric_ShouldThrowInvalidOperationExceptionWhenAccessingException()
    {
        var result = new SuccessResult<int>(100, "Operation successful");
        Assert.Throws<InvalidOperationException>(() => { var ex = result.Exception; });
    }
}