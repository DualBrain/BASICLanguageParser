﻿using System;
using NUnit.Framework;
using System.IO;
using Antlr4.Runtime;
using BASICLanguageParser.Common;

namespace BASICLanguageParser.UT
{
    public class TestBasicProgramTests : TestBaseTest
    {
        protected string programPath = @"..\..\..\bas\";

        [SetUp]
        public void Setup()
        {
        }

        /*************************************Tests****************************************/

        [Test]
        public void SimpleTest()
        {   //tests line number, LET token, math expressions, variables names
            var filename = "simple_test.bas";
            var result = RunProg(filename);
            Assert.AreEqual(0, result.ErrorCount, "Wrong Error Count ProgTest Case: {0}", filename, result);
        }

        [Test]
        public void StringExpressionTest()
        {   //tests line number, LET token, math expressions, variables names
            var filename = "string_expression_test.bas";
            var result = RunProg(filename);
            Assert.AreEqual(0, result.ErrorCount, "Wrong Error Count ProgTest Case: {0}", filename, result);
        }

        /*************************************Internal****************************************/

        private ErrorResult RunProg(string filename)
        {
            string path = Path.Combine(Environment.CurrentDirectory, programPath, filename);
            AntlrFileStream stream = new AntlrFileStream(path);
            TestBasicLexer lexer = new TestBasicLexer(stream);
            LexErrorListener lexErrorListener = new LexErrorListener();
            lexer.AddErrorListener(lexErrorListener);
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            TestBasicParser parser = new TestBasicParser(commonTokenStream);
            ErrorListener parseErrorListener = new ErrorListener();
            parser.AddErrorListener(parseErrorListener);
            TestBasicParser.ProgContext progContext = parser.prog();
            TestBasicBaseVisitor<object> visitor = new TestBasicBaseVisitor<object>();
            visitor.Visit(progContext);
            parser.RemoveErrorListeners();
            ErrorResult errorResult = new ErrorResult();
            errorResult.ErrorCount = lexErrorListener.Errors.Count + parseErrorListener.Errors.Count;
            errorResult.LexerErrorCount = lexErrorListener.Errors.Count;
            errorResult.ParserErrorCount = parseErrorListener.Errors.Count;
            errorResult.LexerErrorList = lexErrorListener.Errors;
            errorResult.ParserErrorList = parseErrorListener.Errors;
            return errorResult;
        }
    }
}
