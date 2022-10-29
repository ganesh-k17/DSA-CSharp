# Factorial

Usecases:

* It's very useful for when we're trying to count how many different orders there are for things or how many different 
ways we can combine things. For example, how many different ways can we arrange nnn things? We have nnn choices for 
the first thing. For each of these n choices, we are left with n-1 choices for the second thing, so 
that we have n.(n-1) choices for the first two 
things, in order. Now, for each of these first two choices, we have n-2n−2n, minus, 2 choices for the third thing, 
giving us n \cdot (n-1) \cdot (n-2)n⋅(n−1)⋅(n−2)n, dot, left parenthesis, n, minus, 1, right parenthesis, dot, left 
parenthesis, n, minus, 2, right parenthesis choices for the first three things, in order. And so on, until we get down 
to just two things remaining, and then just one thing remaining. Altogether, we have n.(n-1).(n-2) choices for the first 
three things, in order. And so on, until we get down to just two things remaining, and then just one thing remaining. Altogether, we have
n⋅(n−1)⋅(n−2)⋯2⋅1 ways that we can order n things. And that product is just n!(n factorial), but with the product written going 
from n down to 1 rather than from 1 up to n.


* Another use for the factorial function is to count how many ways you can choose things from a collection of things. 
For example, suppose you are going on a trip and you want to choose which T-shirts to take. Let's say that you own n T-shirts 
but you have room to pack only k of them. How many different ways can you choose k T-shirts from a collection of nnn T-shirts? 
The answer (which we won't try to justify here) turns out to be n! / (k! . (n-k)!)  So the factorial function can be pretty useful. 
You can learn more about permutations and combinations [https://www.khanacademy.org/v/permutations](here)(
but you don't need to understand them to implement a factorial algorithm.

## We can distill the idea of recursion into two simple rules:

* Each recursive call should be on a smaller instance of the same problem, that is, a smaller subproblem.
* The recursive calls must eventually reach a base case, which is solved without further recursion.