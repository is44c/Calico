;; 
;; Calico - Scripting Environment
;; 
;; Copyright (c) 2011, Doug Blank <dblank@cs.brynmawr.edu>
;; 
;; This program is free software: you can redistribute it and/or modify
;; it under the terms of the GNU General Public License as published by
;; the Free Software Foundation, either version 3 of the License, or
;; (at your option) any later version.
;; 
;; This program is distributed in the hope that it will be useful,
;; but WITHOUT ANY WARRANTY; without even the implied warranty of
;; MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
;; GNU General Public License for more details.
;; 
;; You should have received a copy of the GNU General Public License
;; along with this program.  If not, see <http://www.gnu.org/licenses/>.
;; 
;; $Id: $

(define fact1
    "Factorial for Scheme"
    (lambda (n)
        (if (eq? n 1)
            1
            (* n (fact1 (- n 1))))))

(define! fact2
    "Factorial seen by the DLR languages; can't run"
    (lambda (n)
        (if (eq? n 1)
            1
            (* n (fact2 (- n 1))))))

(define! fact3
  "Factorial available and runnable by DLR languages"
  (func fact2))
