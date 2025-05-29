// <copyright file="Failure.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult;

/// <summary>
/// Represents the base class for a failure result in the PerfectResult library.
/// </summary>
public class Failure : PResult, IFailure
{
    private readonly string? _message;
    private readonly Exception? _exception;

    /// <summary>
    /// Creates a new instance of the <see cref="Failure"/> class with an optional message and exception.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="exception"></param>
    public Failure(string? message, Exception? exception = null)
    {
        _message = message;
        _exception = exception;
    }

    /// <summary>
    /// Gets the exception thrown during the operation.
    /// </summary>
    public Exception Exception
    {
        get
        {
            if (_exception is null)
            {
                return new Exception("A failure occurred, but no exception was provided.");
            }

            return _exception;
        }
    }

    /// <inheritdoc />
    public override string Message
    {
        get
        {
            if (_message is null)
            {
                return "Operation failed.";
            }

            return _message;
        }
    }
}