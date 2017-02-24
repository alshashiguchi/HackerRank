(def lst [2 -4 3 -1 23 -4 -54])

(map (fn[x] (if (< x 0) (* x -1) x)) lst)

(map (fn[x] (if (< x 0) (println (* x -1)) (println x) )) lst)

(fn[lst] (map (fn[x] (if (< x 0) (println (* x -1)) (println x) )) lst))