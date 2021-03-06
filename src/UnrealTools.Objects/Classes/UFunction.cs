﻿using UnrealTools.Core;
using UnrealTools.Core.Enums;
using UnrealTools.Objects.Enums;
using UnrealTools.Objects.Package;

namespace UnrealTools.Objects.Classes
{
    internal class UFunction : UStruct
    {
        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            reader.ReadUnsafe(out _functionFlags);

            if ((_functionFlags & EFunctionFlags.Net) != 0)
                reader.Read(out _repOffset);

            if (reader.Version >= UE4Version.VER_UE4_SERIALIZE_BLUEPRINT_EVENTGRAPH_FASTCALLS_IN_UFUNCTION)
            {
                reader.Read(out _eventGraphFunction);
                reader.Read(out _eventGraphCallOffset);
            }
        }


        private EFunctionFlags _functionFlags;
        private ResolvedObjectReference<UFunction> _eventGraphFunction = null!;
        private int _eventGraphCallOffset;
        private short _repOffset;
    }
}
