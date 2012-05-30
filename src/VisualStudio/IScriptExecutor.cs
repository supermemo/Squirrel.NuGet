﻿using EnvDTE;
using System.Runtime.Versioning;

namespace NuGet.VisualStudio
{
    public interface IScriptExecutor
    {
        bool Execute(string installPath, string scriptFileName, IPackage package, Project project, ILogger logger);
        bool Execute(string installPath, string scriptFileName, IPackage package, Project project, FrameworkName targetFramework, ILogger logger);
    }
}