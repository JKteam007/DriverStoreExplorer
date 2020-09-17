using System.Collections.Generic;

namespace Rapr.Utils
{
    public interface IDriverStore
    {
        DriverStoreType Type { get; }

        string OfflineStoreLocation { get; }

        bool SupportAddInstall { get; }

        bool SupportForceDeletion { get; }

        bool SupportDeviceNameColumn { get; }

        List<DriverStoreEntry> EnumeratePackages();

        bool DeleteDriver(DriverStoreEntry driverStoreEntry, bool forceDelete);

        bool AddDriver(string infFullPath, bool install);
    }
}
