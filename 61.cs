 class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            var result = RotateRight(head, 2);
        }

        static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return head;
            ListNode fast = head;
            ListNode slow = head;
            int len = 0;
            while (fast != null)
            {
                len++;
                fast = fast.next;
            }
            fast = head;
            for (int i = 0; i < k % len; i++)
            {
                fast = fast.next;
            }
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            fast.next = head;
            head = slow.next;
            slow.next = null;
            return head;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
