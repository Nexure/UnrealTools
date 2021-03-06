﻿using System.Diagnostics;
using UnrealTools.Core;
using UnrealTools.Objects.Classes;

namespace UnrealTools.Objects.Package
{
    [DebuggerDisplay("Ref: {Value}")]
    public sealed class ResolvedObjectReference<T> : ObjectReference where T : TaggedObject
    {
        public static implicit operator ResolvedObjectReference<T>(T value) => new ResolvedObjectReference<T>(value);

        public T? Value { get; private set; }

        public ResolvedObjectReference() { }
        public ResolvedObjectReference(T value) => Value = value;

        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            Value = Resource?.Read(reader) as T;
        }
    }
}
