# Memoization Demo

This is a simple demonstration of the difference between a na&iuml;ve implementation of a recursive algorithm and a memoized implementation. 

A computing problem has overlapping subproblems if it can be broken down into subproblems that must (at least conceptually) be re-solved multiple times.
If we blindly solve these subproblems repeatedly, we could end up doing a lot of unnecessary work. 

In this example, the problem is the recursive computation of _f_<sub>n</sub> (the _n_<sup>th</sup> Fibonacci number), and the subproblems are the computations of _f_<sub>_n_-1</sub> and _f_<sub>_n_-2</sub> (the preceding 2 Fibonacci numbers). If we examine the subproblem of computing _f_<sub>_n_-1</sub>, we see that it requires computing _f_<sub>_n_-2</sub> and _f_<sub>_n_-3</sub>; thus, computing _f_<sub>_n_-2</sub> is an overlapping subproblem, since it must be solved for both _f_<sub>_n_</sub> and _f_<sub>_n_-1</sub>. Extending this further, we can see that there will be many more overlapping subproblems involved in computing _f_<sub>_n_</sub>&mdash;in fact, the number of computations of component _f_<sub>_i_</sub> values grows at about the same rate as as the value of _f_<sub>_n_</sub> itself!

There are 2 general approaches to solving such a problem, while avoiding the repeated solutions of overlapping subproblems<sup>[1](#footnote-1)</sup>:

- Solve in a bottom-up fashion. In this case, that would entail starting with _f_<sub>0</sub> and _f_<sub>1</sub> (by definition, these values are 0 and 1, respectively), and then iteratively compute _f_<sub>2</sub>, _f_<sub>3</sub>, &hellip;, _f_<sub>_n_</sub>.

- Solve in a top-down, recursive fashion&mdash;but storing (_memoizing_) the solutions to the subproblems as each is solved, and looking first to these memoized results when a subproblem solution is needed. This is the approach demonstrated here.

<a name="footnote-1">1</a>: For the purposes of this introduction, closed-form methods (such as Stirling's approximation) are not addressed.