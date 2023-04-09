using LeetCodeCSharp;
namespace LeetCodeCsharpTests
{
    public class LinkedListCycleTests
    {
        public LinkedListCycleSolution Solution { get; set; }
        public ListNode listNode { get; set; }

        public LinkedListCycleTests()
        {
            Solution = new LinkedListCycleSolution();
        }

        [Test]
        public void Cycled()
        {
            listNode = new ListNode(3);
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            var cycleNode = new ListNode(4);
            list.next.next.next = cycleNode;
            list.next.next.next.next = new ListNode(5);
            list.next.next.next.next.next = new ListNode(6);
            list.next.next.next.next.next.next = cycleNode;

            Assert.AreEqual(true, Solution.HasCycle(list));
        }
    }
}