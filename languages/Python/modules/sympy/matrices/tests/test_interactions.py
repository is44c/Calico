"""
We have a few different kind of Matrices
MutableMatrix, ImmutableMatrix, MatrixExpr

Here we test the extent to which they cooperate
"""

from sympy import symbols
from sympy.matrices import (Matrix, MatrixSymbol, eye, Identity,
        ImmutableMatrix)
from sympy.matrices.matrices import MutableMatrix, classof
from sympy.utilities.pytest import raises, XFAIL



SM = MatrixSymbol('X', 3, 3)
MM = Matrix([[1,2,3], [4,5,6], [7,8,9]])
IM = ImmutableMatrix([[1,2,3], [4,5,6], [7,8,9]])
meye = eye(3)
imeye = ImmutableMatrix(eye(3))
ideye = Identity(3)
a,b,c = symbols('a,b,c')

def test_IM_MM():
    assert (MM+IM).__class__ is MutableMatrix
    assert (IM+MM).__class__ is MutableMatrix
    assert (2*IM + MM).__class__ is MutableMatrix
    assert MM.equals(IM)

def test_ME_MM():
    assert (Identity(3) + MM).__class__ is MutableMatrix
    assert (SM + MM).__class__ is MutableMatrix
    assert (MM + SM).__class__ is MutableMatrix
    assert (Identity(3) + MM)[1,1] == 6

def test_equality():
    a,b,c = Identity(3), eye(3), ImmutableMatrix(eye(3))
    for x in [a,b,c]:
        for y in [a,b,c]:
            assert x.equals(y)

def test_matrix_symbol_MM():
    X = MatrixSymbol('X', 3,3)
    Y = eye(3) + X
    assert Y[1,1] == 1 + X[1,1]

def test_indexing_interactions():
    assert (a * IM)[1,1] == 5*a
    assert (SM + IM)[1,1] == SM[1,1] + IM[1,1]
    assert (SM * IM)[1,1] == SM[1,0]*IM[0,1] + SM[1,1]*IM[1,1] + SM[1,2]*IM[2,1]

def test_classof():
    A = MutableMatrix(3,3,range(9))
    B = ImmutableMatrix(3,3,range(9))
    C = MatrixSymbol('C', 3,3)
    assert classof(A,A) == MutableMatrix
    assert classof(B,B) == ImmutableMatrix
    assert classof(A,B) == MutableMatrix
    raises(TypeError, lambda:classof(A,C))
