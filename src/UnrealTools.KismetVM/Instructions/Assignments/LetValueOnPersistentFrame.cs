﻿using System;
using System.IO;
using UnrealTools.Core;
using UnrealTools.Objects.Package;

namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class LetValueOnPersistentFrame : Token
    {
        public override EExprToken Expr => EExprToken.EX_LetValueOnPersistentFrame;

        public Token Expression { get; private set; } = null!;

        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            reader.Read(out _prop);
            Expression = Token.Read(reader);
        }

        public override void ReadTo(TextWriter writer)
        {
            throw new NotImplementedException();
        }

        private ObjectReference _prop = null!;
    }
}
