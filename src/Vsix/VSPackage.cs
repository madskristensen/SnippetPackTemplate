using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace SnippetPackVsix
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", Vsix.Version, IconResourceID = 400)]
    [Guid("cb581b54-f056-4eca-b408-0a8608b615ae")]
    public sealed class VSPackage : Package
    {
        protected override void Initialize()
        {
            base.Initialize();
        }
    }
}
