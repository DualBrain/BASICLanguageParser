10 'if then else
20 A=5
30 IF A=10 500
40 IF A=10 THEN 500
50 IF A=10 THEN GOTO500
60 IF A=10 THEN GOTO 500
70 IF A=10 THEN500
80 IF A=20 THEN A=5 ELSE500
90 IF A=20 THEN A=5 ELSE 500
100 IF A=20 THEN A=5 ELSE GOTO500
110 IF A=20 THEN A=5 ELSE GOTO 500
120 IF A=30 THEN A=5
130 IF A=30 THEN A=5: A=10: A=15: A=20
140 IF A$="TEST" THEN A$="BOB"
150 IF AA$="TEST BOB" THEN AA$="TOM TOM"
160 IF AA$(1,4)="SAM" THEN AA$(5,6)="SALLY"
170 IF "SAM"=AA$(9,10,1000) THEN A=8
180 IF Z$="L" THEN500
190 IF Z2$="P" THEN AB=5 
200 IF A$="TEST" THEN A$="BOB" ELSE500
210 IF A$="TEST" THEN A$="BOB" ELSE T=8
220 IF A$=K$ THEN K$="ABCDEF"
230 IF A$=M$ THEN M$="MNOP" ELSE POP=7000
240 IF A=10 AND B=20 AND C=30 AND D=40 THEN 500
250 IF A=10 OR B=20 OR C=30 OR D=40 THEN 500
260 IF A=10 AND B=20 OR C=30 AND D=40 THEN 500
270 IF A=10 OR B=20 AND C=30 OR D=40 THEN 500