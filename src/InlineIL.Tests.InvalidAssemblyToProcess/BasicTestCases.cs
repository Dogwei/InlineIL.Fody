﻿using System.Diagnostics.CodeAnalysis;
using InlineIL;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
public class BasicTestCases
{
    public void InvalidUnreachable()
    {
        IL.Unreachable();
    }

    public void InvalidReturn()
    {
        IL.Return<int>();
    }
}
