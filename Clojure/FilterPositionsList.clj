(def lst [8 15 22 1 10 6 2 18 18 1])


(map (fn [x] (if (odd? x) (println (nth lst x)) ) ) (range(count lst)))


(fn[lst] (map (fn [x] (if (odd? x) (println (nth lst x)))) (range(count lst))))



;(map (fn [x] (if (odd? x) (println (get lst x)) ) ) (range(count lst)))
; (map (fn [x] (if (odd? (.indexOf lst x)) (println x))) lst)


; (fn[lst] (map (fn [x] (if (odd? (.indexOf lst x)) (println x))) lst))


; (map (fn [x] (if (odd? (.indexOf lst x)) (println x))) lst)

; (keep-indexed #(if (= e %2) %1) lst)) 

; (map (fn [x] (keep-indexed #(if (= x %2) x) x))  lst)