 (def num 5)
 (def lst [1, 2, 3, 4, 5])

 (fn [num lst] (flatten (map (fn [x] (repeat num x)) lst)))

; Toma qualquer combinação aninhada de coisas seqüenciais (listas, vetores,
; Etc) e retorna seu conteúdo como uma única seqüência plana.
; (Flatten nil) retorna uma seqüência vazia.
 ;flatten retorna um array
 ;(map (fn [x] (repeat num x)) lst) replica o resultado do array = ((1 1 1 1 1) (2 2 2 2 2) (3 3 3 3 3) (4 4 4 4 4) (5 5 5 5 5))

 ; (flatten (map (fn [x] (repeat num x)) lst))
 ; (1 1 1 1 1 2 2 2 2 2 3 3 3 3 3 4 4 4 4 4 5 5 5 5 5)