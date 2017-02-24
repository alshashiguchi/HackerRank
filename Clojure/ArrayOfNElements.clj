(
    let [lines (line-seq (java.io.BufferedReader. *in*))] (
        println(
            (fn[n] (take n (iterate inc 1)))            
            (Integer. (first lines))
        )
    )
)

; iterate - Returns a lazy sequence of x, (f x), (f (f x)) etc. f must be free of side-effects
; take - Returns a lazy sequence of the first n items in coll, or all items if
; there are fewer than n.  Returns a stateful transducer when
; no collection is provided.
; ex: (take 3 '(1 2 3 4 5 6))
;     => (1 2 3)