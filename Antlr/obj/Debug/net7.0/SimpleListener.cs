﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\User\Desktop\Antlr\Antlr\Simple.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SimpleParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface ISimpleListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>a1</c>
	/// labeled alternative in <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA1([NotNull] SimpleParser.A1Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>a1</c>
	/// labeled alternative in <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA1([NotNull] SimpleParser.A1Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>b1</c>
	/// labeled alternative in <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterB1([NotNull] SimpleParser.B1Context context);
	/// <summary>
	/// Exit a parse tree produced by the <c>b1</c>
	/// labeled alternative in <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitB1([NotNull] SimpleParser.B1Context context);

	/// <summary>
	/// Enter a parse tree produced by the <c>pBooleanLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPBooleanLiteral([NotNull] SimpleParser.PBooleanLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pBooleanLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPBooleanLiteral([NotNull] SimpleParser.PBooleanLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>pIntegerLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPIntegerLiteral([NotNull] SimpleParser.PIntegerLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pIntegerLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPIntegerLiteral([NotNull] SimpleParser.PIntegerLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>pStringLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPStringLiteral([NotNull] SimpleParser.PStringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>pStringLiteral</c>
	/// labeled alternative in <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPStringLiteral([NotNull] SimpleParser.PStringLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] SimpleParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] SimpleParser.StartContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclarations([NotNull] SimpleParser.MethodDeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclarations([NotNull] SimpleParser.MethodDeclarationsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclaration([NotNull] SimpleParser.MethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclaration([NotNull] SimpleParser.MethodDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodHeader([NotNull] SimpleParser.MethodHeaderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodHeader([NotNull] SimpleParser.MethodHeaderContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] SimpleParser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] SimpleParser.MethodBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] SimpleParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] SimpleParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmbeddedStatement([NotNull] SimpleParser.EmbeddedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.embeddedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmbeddedStatement([NotNull] SimpleParser.EmbeddedStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodName([NotNull] SimpleParser.MethodNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodName([NotNull] SimpleParser.MethodNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclaration([NotNull] SimpleParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclaration([NotNull] SimpleParser.LocalVariableDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodCall([NotNull] SimpleParser.MethodCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodCall([NotNull] SimpleParser.MethodCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.variableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableType([NotNull] SimpleParser.VariableTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.variableType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableType([NotNull] SimpleParser.VariableTypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.variableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableName([NotNull] SimpleParser.VariableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.variableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableName([NotNull] SimpleParser.VariableNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableValue([NotNull] SimpleParser.VariableValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SimpleParser.variableValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableValue([NotNull] SimpleParser.VariableValueContext context);
}
} // namespace Antlr
