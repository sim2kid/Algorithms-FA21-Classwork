# Algorithms FA21 Classwork
For each week's worth of class work, I will update what we did here in this ReadMe and the associated C# files will be under that week's folder. I will have each week under it's own project as well in Visual Studio going forward.

# Week 1
We learned about BigO. No projects are avlaiable from Week 1.

# Week 2
2.9: Assignment I: Code Examples and Portfolio Start<br>
We demonstrated our understanding of Big O through some demo code. See the Week 2 folder for that specific class.

# Week 5
5.9: Assignment II: Fisher-Yates Shuffle<br>
We learned how to do a Fisher-Yates Shuffle. To put simply, you just start from one end of an array and pick a random object from the other end (including where you're at) and swap the objects, then you take a step. This will result in a well shuffled array! All of the code is under the Fisher-Yates Shuffle project and is on the Week 5 Branch. You can see all of the work on github as well [by clicking this link](https://github.com/sim2kid/Algorithms-FA21-Classwork/blob/main/Fisher-Yates%20Shuffle/FisherYates.cs)

# Week 8
8.7: Assignment III: Data Structures<br>
For week 8, we went over data types and when to use them. These are avalible to look at in the "Data Structures" project in the repository.
Here's the output and the explanation for that script.
<details>
  <summary>Console Output</summary>
  <br>
  
```
Strating off, we have Arrays and Maps. An array is just a list of like values. They're usually indexed by their position in an array.
Here's an example array with 5 values in it.
[0]: "1"
[1]: "2"
[2]: "3"
[3]: "4"
[4]: "5"
In the case of an Array, all the values are directly mapped to their position.
This is the generic way to store a bunch of values.

In a Map/Dictionaty/Hash Table, these objects are instead mapped to another string/object. This improves preformance of finding and inserting objects by abstracting their location into hashes.
Here's an example of the previous array mapping to random values of letters.
"1" : "pPuQwFkUmjoTdTfGq"
"2" : "bJwduFmBFnVEQRPjxhypM"
"3" : "PYdRFroeKiSVDdxSrwGHMHB"
"4" : "cSGYjawxDpAac"
"5" : "kPDqEuCvQdbwRLCubu"

Dictionaries are best when you don't need an ordered list or if you're storing a lot of data that you're not going to loop through very often.
In other words, it's best if you're going to pick a value based off of the key.

We can use those ways of storing data and wrap them in ways to access data.
Two of those ways are Stacks and Queues.

A Stack is a First In Last Out data structure.
It's like putting sheets of paper on top of eachother. You can't access the lower papers without removing the one on top.
Let's take a stack of 100000 values and add all of those as numbers in order.
The current top number is "100000" which is the last number we added.
If we take of 10 from the stack, the new top number should be 99990.
If we take a look after doing so, the number is the same, "99990"

Now looking at Queue, the Queue is a First in First out system.
Let's make our Queue with the same array as the stack.
Our current begining of the Queue is "1" which is the first number in our queue.
If we dequeue 22 objects, then our next position in the queue is "23"
```
  
</details>
