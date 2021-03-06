﻿using System;
using System.IO;
using UnrealTools.Core;
using UnrealTools.Objects.Package;

namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class SetConst : ListToken
    {
        public override EExprToken Expr => EExprToken.EX_SetConst;

        public ObjectReference InnerProp => _innerProp;
        public int Count => _count;
        public TokenList Items { get; } = new TokenList();

        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            reader.Read(out _innerProp);
            reader.Read(out _count);
            Items.ReadUntil(reader, EExprToken.EX_EndSetConst);
        }

        public override void ReadTo(TextWriter writer)
        {
            throw new NotImplementedException();
        }

        private ObjectReference _innerProp = null!;
        private int _count;
    }
}
