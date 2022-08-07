// 1.1
let g n = n + 4
let result1 = g(3)
printfn $"should be 7: %i{result1}\n"

// 1.2
let h (x,y) = System.Math.Sqrt((x*x) + (y*y))
let result2 = h(3.0,4.0)
printfn $"should be 5.0: %f{result2}\n"

// 1.3
// ???

// 1.4
let rec f = function
| 1 -> 1
| n -> n + f(n - 1)

let result3 = f(3)
printfn $"should be 6: %i{result3}\n"

// 1.5
let rec fib = function
| 0 -> 0
| 1 -> 1
| n -> fib(n - 1) + fib(n - 2)

let result4 = fib(6)
printfn $"should be 8: %i{result4}\n"

// 1.6
let rec sum = function
| (m, 0) -> m
| (m, n) -> m + n + sum(m, n - 1)

let result5 = sum(3,3)
printfn $"should be 18: %i{result5}\n"

// 1.7
// ???

// 1.8
// ???