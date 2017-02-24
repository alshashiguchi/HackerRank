(use '[clojure.string :only (split triml)])

(defn fact[x]
  (if (<= x 1)
    1
    (* x (fact (- x 1))
  )))

(let [n_t (read-line) n (Integer/parseInt n_t) ]
  (loop [a0 n]
    (when (> a0 0)
      (let [x_t (read-line) x (Float/parseFloat x_t) ]            
        (println(reduce + (for [i (range 10)] (/ (Math/pow x i) (fact i))))))
    (recur (- a0 1)))))