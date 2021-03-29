using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace WinUIEssentials
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(WinUIEssentialsPackage.PackageGuidString)]
    [InstalledProductRegistration("WinUI Essentials", "The easiest way to set up Visual Studio for the ultimate WinUI development experience.", "1.1")]
    public sealed class WinUIEssentialsPackage : AsyncPackage
    {
        public const string PackageGuidString = "0a5c1cc2-dbb8-4790-902d-2a6c8ee03a65";
    }
}
