# Rotation
array and link list rotation in c#

#Array

Given an array of integers arr[] of size N and an integer, the task is to rotate the array elements to the left by d positions.

Examples:  

Input: 
arr[] = {1, 2, 3, 4, 5, 6, 7}, d = 2
Output: 3 4 5 6 7 1 2

Input: arr[] = {3, 4, 5, 6, 7, 1, 2}, d=2
Output: 5 6 7 1 2 3 4
At each iteration, shift the elements by one position to the left circularly (i.e., first element becomes the last).
Perform this operation d times to rotate the elements to the left by d position.
Illustration:

Let us take arr[] = [1, 2, 3, 4, 5, 6, 7], d = 2.

First Step:
        => Rotate to left by one position.
        => arr[] = {2, 3, 4, 5, 6, 7, 1}

Second Step:
        => Rotate again to left by one position
        => arr[] = {3, 4, 5, 6, 7, 1, 2}

Rotation is done by 2 times.
So the array becomes arr[] = {3, 4, 5, 6, 7, 1, 2}

#Link List

Deque is also known as double ended queue. 
Module also provides different in-built methods.
One of them is “rotate”.
Time complexity: The time complexity of the code is O(d*n), where d is the number of rotations and n is the size of the deque. 
The auxiliary space is O(n), where n is the size of the deque.
