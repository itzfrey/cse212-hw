using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
// Scenario: Enqueue items with different priorities, highest priority should come out first
// Expected Result: "High" is dequeued before "Medium" and "Low"
// Defect(s) Found: Loop was not checking last item; item was not removed after dequeue
public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("Low", 1);
    priorityQueue.Enqueue("Medium", 5);
    priorityQueue.Enqueue("High", 10);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("High", result);
}

[TestMethod]
// Scenario: Enqueue items where the highest priority is the last item added
// Expected Result: The last item added should be dequeued first
// Defect(s) Found: Loop condition < Count-1 skipped the last element
public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("First", 1);
    priorityQueue.Enqueue("Second", 2);
    priorityQueue.Enqueue("Highest", 10); // added last, highest priority

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("Highest", result);
}

[TestMethod]
// Scenario: Dequeue from an empty queue
// Expected Result: InvalidOperationException with message "The queue is empty."
// Defect(s) Found: None
public void TestPriorityQueue_Empty()
{
    var priorityQueue = new PriorityQueue();
    try
    {
        priorityQueue.Dequeue();
        Assert.Fail("Exception should have been thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}
}