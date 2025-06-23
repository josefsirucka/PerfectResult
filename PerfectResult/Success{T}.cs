// <copyright file="Success{T}.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult;

public class Success<T> : PResult, IPResult<T>
{
    private readonly T _value;
    private readonly string? _message;
    
    /// <summary>
    /// Creates a new instance of the <see cref="Success{T}"/> class with the specified value.
    /// </summary>
    /// <param name="value">Value to return.</param>
    /// <param name="message">Message to result.</param>
    public Success(T value, string? message)
    {
        _message = message;
        _value = value;
    }

    /// <inheritdoc />
    public T Value
    {
        get
        {
            return _value;
        }
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
