﻿using System.IO;
using UnrealTools.Core;

namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class Tracepoint : Token
    {
        public override EExprToken Expr => EExprToken.EX_Tracepoint;

        public override void Deserialize(FArchive reader) => base.Deserialize(reader);

        public override void ReadTo(TextWriter writer) => writer.WriteLine("Tracepoint");
    }
}
