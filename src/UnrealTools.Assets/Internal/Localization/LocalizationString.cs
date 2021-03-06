﻿using UnrealTools.Core;
using UnrealTools.Core.Interfaces;

namespace UnrealTools.Assets.Internal.Localization
{
    internal class LocalizationString : IUnrealDeserializable
    {
        public FString Value => _value;
        public LocalizationString() : this(null!) { }
        public LocalizationString(FString value) => _value = value;

        public void Deserialize(FArchive reader)
        {
            reader.Read(out _value);
            reader.Read(out _refCount);
        }

        private FString _value;
        private int _refCount;
    }
}