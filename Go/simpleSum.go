package main

import "fmt"

func main() {
    var size int
    fmt.Scan(&size)
    
    var sum, number int
    for i := 0; i < size; i++ {
        fmt.Scan(&number)
        sum += number
    }
    
    fmt.Println(sum)
}