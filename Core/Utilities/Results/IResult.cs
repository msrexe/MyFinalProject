﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıc
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
