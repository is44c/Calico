100 T = 0
102 PRINT "Prime numbers counting"
105 INPUT "Limit ? ";LIMIT: LIMIT=INT(LIMIT)
110 FOR N=2 TO limit
120 GOSUB 200
130 NEXT
140 PRINT "There are ";T;" primes smaller than ";LIMIT+1
150 PRINT
160 LOAD "menu.bas"
200 X=2
210 IF N < X*X THEN T=T+1:RETURN
220 IF N MOD X=0 THEN RETURN
230 X=X+1: GOTO 210
