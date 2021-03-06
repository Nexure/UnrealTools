﻿using System;
using System.IO;
using UnrealTools.Core;

namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class PopExecutionFlow : Token
    {
        public override EExprToken Expr => EExprToken.EX_PopExecutionFlow;

        public override void Deserialize(FArchive reader) => base.Deserialize(reader);

        public override void ReadTo(TextWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
