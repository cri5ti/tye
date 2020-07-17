﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;

namespace Microsoft.Tye
{
    public class AzureFunctionServiceBuilder : ServiceBuilder
    {
        public AzureFunctionServiceBuilder(string name, string path)
            : base(name)
        {
            FunctionPath = path;
        }

        public int Replicas { get; set; } = 1;
        public string? Args { get; set; }
        public string FunctionPath { get; }
        public string? FuncExecutablePath { get; set; }
        public FileInfo? ProjectFile { get; set; }
    }
}