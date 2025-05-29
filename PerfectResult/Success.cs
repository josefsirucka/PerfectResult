// <copyright file="Success.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult;

public class Success : PResult, ISuccess
{
    private readonly string? _message;

    /// <summary>
    /// Creates a new instance of the <see cref="Success"/> class with an optional message.
    /// </summary>
    /// <param name="message">Message to result.</param>
    public Success(string? message)
    {
        _message = message;
    }

    /// <inheritdoc />
    public override string Message
    {
        get
        {
            if (_message is null)
            {
                return "Operation successful.";
            }

            return _message;
        }
    }
}