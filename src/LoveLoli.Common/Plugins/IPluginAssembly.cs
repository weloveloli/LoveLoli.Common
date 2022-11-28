#pragma warning disable CS1591
namespace LoveLoli.Common.Plugins
{
    using System;

    public interface IPluginAssembly
    {
        void SetAttributes(string assemblyFilePath, string dataFolderPath, Version assemblyVersion);

        void SetId(Guid assemblyId);
    }
}
