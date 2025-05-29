// <copyright file="MatchExtension.cs" company="Josef Širůčka">
// Copyright (c) Josef Širůčka. All rights reserved.
// </copyright>
// <summary>Created on: 29.05 2025</summary>

namespace PerfectResult;

public static class MatchExtension
{
    public static IPResult Match(this IPResult result, Action<ISuccess> onSuccess, Action<IFailure> onFailure)
    {
        if (result is ISuccess success)
        {
            onSuccess(success);
        }
        else if (result is IFailure failure)
        {
            onFailure(failure);
        }

        return result;
    }

    public static IPResult Match(this IPResult result, Func<ISuccess, IPResult> onSuccess, Func<IFailure, IPResult> onFailure)
    {
        if (result is ISuccess success)
        {
            return onSuccess(success);
        }
        else if (result is IFailure failure)
        {
            return onFailure(failure);
        }

        return result;
    }
}