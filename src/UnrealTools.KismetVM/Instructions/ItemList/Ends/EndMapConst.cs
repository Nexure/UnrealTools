﻿namespace UnrealTools.KismetVM.Instructions
{
    internal sealed class EndMapConst : EndToken
    {
        public override EExprToken Expr => EExprToken.EX_EndMapConst;
    }
}
