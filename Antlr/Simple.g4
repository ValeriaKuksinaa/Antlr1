grammar Simple;
/*
 * Parser Rules
 */

start : methodDeclarations? EDF;
methodDeclarations : methodDeclaration+;
methodDeclaration : methodHeader methodBody;
methodHeader : 'public' 'static' 'void' methodName '(' ')';
methodBody : '{' statement* '}';
statement : embeddedStatement ';';
embeddedStatement
	: localVariableDeclaration	#a1
	| methodCall				#b1
	;

methodName : WORD;

localVariableDeclaration : variableType variableName ('=' variableValue)? ;
methodCall : methodName '(' ')';
variableType : 'int' | 'byte' | 'string' | 'bool';
variableName : WORD;
variableValue
	: BooleanLiteral	#pBooleanLiteral
	| IntegerLiteral	#pIntegerLiteral
	| StringLiteral		#pStringLiteral
	;

BooleanLiteral : 'true' | 'false';
IntegerLiteral : [a-z]+;
StringLiteral : '"' .*? '"'; 

WORD                : [a-zA-Z]+ ;

/*
//chat                : line line EOF ;
line                : name 'says' opinion NEWLINE;
name                : WORD ;
opinion             : TEXT ;

WORD                : [a-zA-Z]+ ;
TEXT                : '"' .*? '"' ;
WHITESPACE          : (' '|'\t')+ -> skip ;
NEWLINE             : ('\r'? '\n' | '\r')+ ;
*/