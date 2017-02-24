
(def lst [8 15 22 1 10 6 2 18 18 1])
 (reduce +  (map (fn[x] (if (odd? x) x 0)) teste))
 (fn[lst] (reduce +  (map (fn[x] (if (odd? x) x 0)) lst)))
; 


; (map (fn [x] (if (odd? x) )) lst)