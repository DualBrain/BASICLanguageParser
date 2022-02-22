//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Stephen\source\repos\BASICLanguageParser\BASICLanguageParser.Grammar\ColorBasic.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace BASICLanguageParser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ColorBasicParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public interface IColorBasicVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] ColorBasicParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] ColorBasicParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] ColorBasicParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] ColorBasicParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.characterExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharacterExpression([NotNull] ColorBasicParser.CharacterExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelationalExpression([NotNull] ColorBasicParser.RelationalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelop([NotNull] ColorBasicParser.RelopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.variableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableList([NotNull] ColorBasicParser.VariableListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.absfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbsfunc([NotNull] ColorBasicParser.AbsfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ascfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAscfunc([NotNull] ColorBasicParser.AscfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.sgnfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSgnfunc([NotNull] ColorBasicParser.SgnfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.intfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntfunc([NotNull] ColorBasicParser.IntfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.sinfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSinfunc([NotNull] ColorBasicParser.SinfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.rndfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRndfunc([NotNull] ColorBasicParser.RndfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.lenfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLenfunc([NotNull] ColorBasicParser.LenfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.valfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValfunc([NotNull] ColorBasicParser.ValfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.chrfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChrfunc([NotNull] ColorBasicParser.ChrfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.midfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMidfunc([NotNull] ColorBasicParser.MidfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.leftfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLeftfunc([NotNull] ColorBasicParser.LeftfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.rightfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRightfunc([NotNull] ColorBasicParser.RightfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.strfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStrfunc([NotNull] ColorBasicParser.StrfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.inkeyfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInkeyfunc([NotNull] ColorBasicParser.InkeyfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.joystkfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoystkfunc([NotNull] ColorBasicParser.JoystkfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.eoffunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEoffunc([NotNull] ColorBasicParser.EoffuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.peekfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPeekfunc([NotNull] ColorBasicParser.PeekfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.pointfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointfunc([NotNull] ColorBasicParser.PointfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.memfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemfunc([NotNull] ColorBasicParser.MemfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.usrfunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsrfunc([NotNull] ColorBasicParser.UsrfuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.letstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLetstmt([NotNull] ColorBasicParser.LetstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.dimstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDimstmt([NotNull] ColorBasicParser.DimstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.forstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForstmt([NotNull] ColorBasicParser.ForstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.nextstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNextstmt([NotNull] ColorBasicParser.NextstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifthenelsestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfthenelsestmt([NotNull] ColorBasicParser.IfthenelsestmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifthenelsenumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfthenelsenumstmt([NotNull] ColorBasicParser.IfthenelsenumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifthenstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfthenstmt([NotNull] ColorBasicParser.IfthenstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifnumelsenumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfnumelsenumstmt([NotNull] ColorBasicParser.IfnumelsenumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifnumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfnumstmt([NotNull] ColorBasicParser.IfnumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ifstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfstmt([NotNull] ColorBasicParser.IfstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.gotonumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotonumstmt([NotNull] ColorBasicParser.GotonumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.gotostmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGotostmt([NotNull] ColorBasicParser.GotostmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.gosubnumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGosubnumstmt([NotNull] ColorBasicParser.GosubnumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.gosubstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGosubstmt([NotNull] ColorBasicParser.GosubstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ongotonumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOngotonumstmt([NotNull] ColorBasicParser.OngotonumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ongotostmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOngotostmt([NotNull] ColorBasicParser.OngotostmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ongosubnumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOngosubnumstmt([NotNull] ColorBasicParser.OngosubnumstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.ongosubstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOngosubstmt([NotNull] ColorBasicParser.OngosubstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.returnstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnstmt([NotNull] ColorBasicParser.ReturnstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.readstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadstmt([NotNull] ColorBasicParser.ReadstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.restorestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRestorestmt([NotNull] ColorBasicParser.RestorestmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.newstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewstmt([NotNull] ColorBasicParser.NewstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.endstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEndstmt([NotNull] ColorBasicParser.EndstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.stopstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStopstmt([NotNull] ColorBasicParser.StopstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.runstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRunstmt([NotNull] ColorBasicParser.RunstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.clearstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClearstmt([NotNull] ColorBasicParser.ClearstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.contstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContstmt([NotNull] ColorBasicParser.ContstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.liststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListstmt([NotNull] ColorBasicParser.ListstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.lliststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLliststmt([NotNull] ColorBasicParser.LliststmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.inputstmt1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInputstmt1([NotNull] ColorBasicParser.Inputstmt1Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.printstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintstmt([NotNull] ColorBasicParser.PrintstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.printtabstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrinttabstmt([NotNull] ColorBasicParser.PrinttabstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.printhashstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrinthashstmt([NotNull] ColorBasicParser.PrinthashstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.printatstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintatstmt([NotNull] ColorBasicParser.PrintatstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.setstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetstmt([NotNull] ColorBasicParser.SetstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.resetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResetstmt([NotNull] ColorBasicParser.ResetstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.clsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClsstmt([NotNull] ColorBasicParser.ClsstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.execstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExecstmt([NotNull] ColorBasicParser.ExecstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.pokestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPokestmt([NotNull] ColorBasicParser.PokestmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.motorstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMotorstmt([NotNull] ColorBasicParser.MotorstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.audiostmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAudiostmt([NotNull] ColorBasicParser.AudiostmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.soundstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSoundstmt([NotNull] ColorBasicParser.SoundstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.cloadstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCloadstmt([NotNull] ColorBasicParser.CloadstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.cloadmstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCloadmstmt([NotNull] ColorBasicParser.CloadmstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.csavestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCsavestmt([NotNull] ColorBasicParser.CsavestmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.csavemstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCsavemstmt([NotNull] ColorBasicParser.CsavemstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.skipfstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSkipfstmt([NotNull] ColorBasicParser.SkipfstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.openstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpenstmt([NotNull] ColorBasicParser.OpenstmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ColorBasicParser.closestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClosestmt([NotNull] ColorBasicParser.ClosestmtContext context);
}
} // namespace BASICLanguageParser
