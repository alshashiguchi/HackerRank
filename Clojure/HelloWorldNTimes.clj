(fn[n] (dotimes [n n] (println "Hello World"))) 

; bindings => name n
;  Repeatedly executes body (presumably for side-effects) with name
; bound to integers from 0 through n-1.
;(dotimes [n 5] (println "n is" n))