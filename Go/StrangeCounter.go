package main

import "fmt"

func main() {
    var time int
    fmt.Scan(&time)

    total := 0
    n := 3

    for total < time {
        total += n
        n *= 2
    }

    n /= 2

    fmt.Println(total - n + (n - time) + 1)

}
