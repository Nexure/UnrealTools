# UnrealTools

Set of libraries for reading the Unreal Engine 4 binary asset format.

Example usage:
```cs
using UnrealTools.Pak;
using UnrealTools.Assets;

using (var reader = PakVFS.OpenAt(path))
{
    foreach (var (name, entry) in reader.AbsoluteIndex)
    {
        using (var data = entry.Read())
        {
            data.Version = UE4Version.VER_UE4_AUTOMATIC_VERSION;
            data.Read(out UAssetAsset asset);
        }
    }
}
```