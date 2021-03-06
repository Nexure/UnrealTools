﻿using UnrealTools.Core;

namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class IntOne : ConstToken<int>
    {
        public override EExprToken Expr => EExprToken.EX_IntOne;

        public override void Deserialize(FArchive reader)
        {
            base.Deserialize(reader);
            _value = 1;
        }
    }
}
