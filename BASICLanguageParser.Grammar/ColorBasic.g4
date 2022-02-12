
grammar ColorBasic;
options
{
    language=CSharp;
}

/*
[The "BSD licence"]
Copyright (c) 2022 Stephen Sorrell
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions
are met:
1. Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright
notice, this list of conditions and the following disclaimer in the
documentation and/or other materials provided with the distribution.
3. The name of the author may not be used to endorse or promote products
derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/// a program is a collection of lines

/*
Description: Grammar for Color Basic 1.2 for the TRS-80 Color Computer

Color Basic is a tiny basic created by Microsoft.  Version 1.2 is copyright 1983.
It is very similar to the two prior versions.  This comes primarily from the
Color Basic Unravelled series and the Color Computer Basic Manual and Quick Reference.
*/

/******************************Parser***************************************/
prog
   : line+ EOF
   ;

// a line starts with an integer
line
   : LINE_NUMBER (statement | COMMENT) (':' (statement | COMMENT))*
   ;

/****************************master statement table*************************************/
statement
    : letstmt
    | returnstmt
    | restorestmt
    | printstmt
    | nextstmt
    | pokestmt
    | ifstmt1
    | ifstmt2
    | forstmt
    | inputstmt1
    | dimstmt
    | gotostmt
    | gosubstmt
    | readstmt
   //  | datastmt
    | printstmt
    | printtabstmt
    | printhashstmt
    | printatstmt
    | newstmt
    | stopstmt
    | endstmt
    | runstmt
    | clearstmt
    | contstmt
    | liststmt
    | lliststmt
    | setstmt
    | resetstmt
    | clsstmt
    | execstmt
    | motorstmt
    | audiostmt
    | soundstmt
    | cloadstmt
    | cloadmstmt
    | csavestmt
    | csavemstmt
    | skipfstmt
    | openstmt
    | closestmt
   ;

/****************************master function table*************************************/
// func_
//    : STRINGLITERAL
//    | signed_number
//    | variableDeclaration
//    | chrfunc
//    | lenfunc
//    | strfunc
//    | midfunc
//    | peekfunc
//    | intfunc
//    | leftfunc
//    | valfunc
//    | rightfunc
//    | sinfunc
//    | rndfunc
//    | sgnfunc
//    | absfunc
//    | inkeyfunc
//    | joystkfunc
//    | eoffunc
//    | pointfunc
//    | memfunc
//    | usrfunc
//    | ('(' expression ')')
//    ;

// exprs and such
// signed_number
//    :  ('+' | '-')? (NUMBER)
//    ;

// signExpression
//    : NOT+ ('+' | '-')? func_
//    ;

// exponentExpression
//    : signExpression ( <assoc=right> '^' signExpression)*
//    ;

// multiplyingExpression
//    : exponentExpression (('*' | '/') exponentExpression)*
//    ;

// addingExpression
//    : multiplyingExpression (('+' | '-') multiplyingExpression)*
//    ;

// relationalExpression
//    : addingExpression ((relop) addingExpression)?
//    ;

// expression
//    : func_
//    | (relationalExpression ((AND | OR) relationalExpression)*)
//    ;

characterExpression
   : characterExpression '+' characterExpression
   | VARIABLE_STRING
   | STRINGLITERAL
   ;

expression
   : '-' expression
   | expression addop expression
   | expression mulop expression
   | expression ( <assoc=right> '^' expression )
   | '(' expression ')'
   | VARIABLE_NUMBER
   | NUMBER
   ;

addop : '+' | '-' ;

mulop : '*' | '/'  ;

relop
   : gte
   | lte
   | neq
   | '='
   | '>'
   | '<'
   ;

neq
   : '<' '>'
   | '>' '<'
   ;

gte
    : '>' '='
    ;

lte
    : '<' '='
    ;

variableDeclaration
   : VARIABLE_NUMBER ('(' expressionList ')')*
   ;

variableList
   : variableDeclaration (',' variableDeclaration)*
   ;

variableAssignment
   : variableDeclaration '=' expression
   ;

expressionList
   : expression (',' expression)*
   ;

// datum
//    : NUMBER
//    | DATUM
//    ;

/*******************functions**********************/
absfunc
   : ABS '(' expression ')'
   ;

ascfunc
   : ASC '(' expression ')'
   ;

sgnfunc
   : SGN '(' expression ')'
   ;

intfunc
   : INT '(' expression ')'
   ;

sinfunc
   : SIN '(' expression ')'
   ;

rndfunc
   : RND '(' expression ')'
   ;

lenfunc
   : LEN '(' expression ')'
   ;

valfunc
   : VAL '(' expression ')'
   ;

chrfunc
   : CHR '(' expression ')'
   ;

midfunc
   : MID '(' expression ',' expression ',' expression ')'
   ;

leftfunc
   : LEFT '(' expression ',' expression ')'
   ;

rightfunc
   : RIGHT '(' expression ',' expression ')'
   ; 

strfunc
   : STR '(' expression ')'
   ;

inkeyfunc
   : INKEY
   ;

joystkfunc
   : JOYSTK '(' expression ')'
   ;

eoffunc
   : EOFTOKEN '(' expression ')'
   ;

peekfunc
   : PEEK '(' expression ')'
   ;

pointfunc
   : POINT '(' expression ',' expression ')'
   ;

memfunc
   : MEM
   ; 

usrfunc
   : USR DIGIT '(' expression ')'
   ;

/*******************statements**********************/

letstmt
   : LET? variableAssignment
   ;

dimstmt
   : DIM variableList
   ;

// for stmt puts the for, the statment, and the next on 3 lines.  It needs "nextstmt"
forstmt
   : FOR variableDeclaration '=' expression TO expression (STEP expression)?
   ;

nextstmt
   : NEXT (variableList)?
   ;

ifstmt1
   : IF expression THEN? (statement+ | LINE_NUMBER)
   ;

ifstmt2
   : IF expression THEN (statement+ | LINE_NUMBER) ELSE (statement+ | LINE_NUMBER)
   ;

gotostmt
   : GO TO LINE_NUMBER
   ;

gosubstmt
   : GO SUB LINE_NUMBER
   ;

ongotostmt
   : ON expression GO TO LINE_NUMBER (',' LINE_NUMBER)*
   ;

ongosubstmt
   : ON expression GO SUB LINE_NUMBER (',' LINE_NUMBER)*
   ;

returnstmt
   : RETURN
   ;

// datastmt
//    : DATA datum+ (',' datum+)*
//    ;

readstmt
   : READ variableList
   ;

restorestmt
   : RESTORE
   ;

newstmt
   : NEW
   ;

endstmt
   : END
   ;

stopstmt
   : STOP
   ;

runstmt
   : RUN
   ;

clearstmt
   : CLEAR
   ;

contstmt
   : CONT
   ;

liststmt
   : LIST
   ;

lliststmt
   : LLIST
   ;

// inputstmt1
//     : INPUT (func_ (INPUT_COMMA func_)*)
//     ;

inputstmt1
   : INPUT ((STRINGLITERAL ';') | ('#' DEVICE_CASSETTE ','))? variableList
   ;

printstmt
   : PRINT characterExpression?
   ;

printtabstmt
   : PRINT TAB '(' expression ')' ';' expression
   ;

printhashstmt
   : PRINT '#' (DEVICE_CASSETTE | DEVICE_PRINTER) ',' expression 
   ;

printatstmt
   : PRINT '@' expression ',' expression 
   ;

setstmt
   : SET '(' expression ',' expression (',' expression)+ ')'
   ;
   
resetstmt
   : RESET '(' expression ',' expression ')'
   ;

clsstmt
   : CLS expression
   ;

execstmt
   : EXEC expression
   ;

pokestmt
   : POKE expression ',' expression
   ;

motorstmt
   : MOTOR (ON | OFF)
   ;

audiostmt
   : AUDIO (ON | OFF)
   ;

soundstmt
   : SOUND expression ',' expression
   ;   

cloadstmt
   : CLOAD expression
   ; 

cloadmstmt
   : CLOAD expression ',' expression
   ; 

csavestmt
   : CSAVE expression ',' expression
   ;

csavemstmt
   : CSAVEM expression ',' expression ',' expression ',' expression
   ; 

skipfstmt
   : SKIPF expression
   ; 

openstmt
   : OPEN ('I' | 'O' ) ',' '#' (DEVICE_KEYBOARD | DEVICE_CASSETTE | DEVICE_PRINTER) ',' expression
   ; 

closestmt
   : CLOSE '#' (DEVICE_CASSETTE)?
   ; 

/******************************Lexer***************************************/   
LET //assign variables
   : 'LET'
   ;

DIM //dim variables
   : 'DIM'
   ;

/*******************functions**********************/
ABS //absolute value
   : 'ABS'
   ;

ASC //get code of first character in string
   : 'ASC'
   ;

SGN //Convert signed number into floating point number.
   : 'SGN'
   ;

INT //Convert float to an integer
   : 'INT'
   ;

SIN //sine wave function
   : 'SIN'
   ;

RND //random number function
   : 'RND'
   ;

LEN //string length function
   : 'LEN'
   ;

VAL //convert a string to a number
   : 'VAL'
   ;

CHR //Convert string to integer
   : 'CHR$'
   ;

MID //return mid portion of string
   : 'MID$'
   ;

LEFT //return left portion of string
   : 'LEFT$'
   ;

RIGHT //return right portion of string
   : 'RIGHT$'
   ;

STR //convert n to string
   : 'STR$'
   ;

INKEY //get key from keyboard
   : 'INKEY$'
   ;

JOYSTK //get the joystick axis
   : 'JOYSTK'
   ;

EOFTOKEN //return false if there is more data on the device
   : 'EOF'
   ;

PEEK //get the contents at the memory address
   : 'PEEK'
   ;

POINT //returns info about the specified point on the screen
   : 'POINT'
   ;

MEM //returns amount of free memory
   : 'MEM'
   ;

USR //call machine language subroutine 0-9
   : 'USR'
   ;

/*******************statements**********************/

FOR //for loop
   : 'FOR'
   ;

TO //for to loop
   : 'TO'
   ;

STEP //for to step loop
   : 'STEP'
   ;

NEXT //next closing statement to loop
   : 'NEXT'
   ;

IF //if 
   : 'IF'
   ;

THEN //if then
   : 'THEN'
   ;

ELSE //if then else
   : 'ELSE'
   ;

GO //goto
   : 'GO'
   ;

SUB //gosub
   : 'SUB'
   ;

ON //on gosub
   : 'ON'
   ;

OFF //off token
    : 'OFF'
    ; 

RETURN //return from a gosub
   : 'RETURN'
   ;

DATA //define data elements
   : 'DATA'
   ;

RESTORE //restore the data pointer back
   : 'RESTORE'
   ;

READ //read from the data statement
   : 'READ'
   ;

NEW //erase basic program, clear variables space,.. 
   : 'NEW'
   ;

END //end program
   : 'END'
   ;

STOP //stop program execution
   : 'STOP'
   ;

RUN //run program
   : 'RUN'
   ;

CONT //continue program execution
   : 'CONT'
   ;

LIST //list program to the screen
   : 'LIST'
   ;

LLIST //list program to printer
   : 'LLIST'
   ;

CLEAR //erase all variables, initialize pointers,..
   : 'CLEAR'
   ;

INPUT //input
    : 'INPUT'
    ;

PRINT //print@ or print# or print or print tab
    : 'PRINT'
    ;

TAB //print tab(22);"hello" move the cursor to the tab position
    : 'TAB'
    ;

SET //set(x,y,c) c is optional set a point on the screen
    : 'SET'
    ;

RESET //reset(x,y) reset a point on the screen
    : 'RESET'
    ;    

CLS //cls n set background color of screen
    : 'CLS'
    ;   

EXEC //transfer control to a machine language address
    : 'EXEC'
    ; 

POKE //put a number in an address
    : 'POKE'
    ; 

MOTOR //turn the cassette on or off
    : 'MOTOR'
    ;   

AUDIO //connect cassette output to the screen
    : 'AUDIO'
    ; 

SOUND //play specified tone and duration
    : 'SOUND'
    ; 

CLOAD //load program from cassette
    : 'CLOAD'
    ;   

CSAVE //save program to cassette
    : 'CSAVE'
    ; 

CLOADM //load machine language program from cassette
    : 'CLOADM'
    ;   

CSAVEM //save machine language program to the cassette
    : 'CSAVEM'
    ; 

SKIPF //skip to the next program on the cassette
    : 'SKIPF'
    ; 

OPEN //open file for data transmission
    : 'OPEN'
    ; 

CLOSE //close acces to the specified device
    : 'CLOSE'
    ; 

COMMENT //match comment stuff '\n'
    : REM .*? '\r'? '\n' -> channel(2)
    ;

REM //comment
    : '\'' | 'REM'
    ;

/*******************small tokens**********************/

OR
   : 'OR'
   ;

AND
   : 'AND'
   ;

NOT
   : 'NOT'
   ;


VARIABLE_NUMBER
   : LETTER (LETTER | DIGIT)*
   ;

VARIABLE_STRING
   : VARIABLE_NUMBER '$'
   ;

DIGIT_SEQUENCE
   : DIGIT+
   ;

LETTER
   : [A-Z]
   ;

DATUM //i think this should be actually much more inclusive - todo redo rule
   : [a-zA-Z0-9]
   ;

STRINGLITERAL
   : '"' ~["\r\n]* '"'
   ;

NUMBER
   : (DIGIT* '.'? DIGIT* ('E' ('+' | '-')? DIGIT_SEQUENCE) | DIGIT* '.' DIGIT* | DIGIT_SEQUENCE)
   ;

LINE_NUMBER
   : DIGIT_SEQUENCE
   ;
   
WS
   : [ \t]+ -> channel (HIDDEN)
   ;

 EOL
   : [\r\n] -> channel (HIDDEN)
   ;  

 /*******************fragments**********************/  
fragment
DEVICE_KEYBOARD
    : '0'
    ;

fragment
DEVICE_CASSETTE
    : '-1'
    ;

fragment
DEVICE_PRINTER
    : '-2'
    ;

fragment
DEVICE_RS232
    : '-3'
    ;

fragment
DIGIT
   : [0-9]
   ;