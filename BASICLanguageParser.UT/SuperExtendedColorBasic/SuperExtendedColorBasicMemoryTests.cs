﻿using System;
using NUnit.Framework;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace BASICLanguageParser.UT
{
    public class SuperExtendedColorBasicMemoryTests : ExtendedColorBasicMemoryTests
    {
        /**
         * Tokens: PEEK POKE CLEAR NEW DATA RESTORE DIM
         */

        [SetUp]
        public new void Setup()
        {
        }

        /*************************************Tests****************************************/

        /*************************************Internal****************************************/

        //protected override int RunABS(string txt)
        //{
        //    SetupLexerParser(txt);
        //    jvmBasicParser.AbsfuncContext absDefinitionContext = parser.absfunc();
        //    int result = VisitNode(absDefinitionContext);
        //    return result;
        //}
    }


}
