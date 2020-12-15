class Program
    {
        static void Main(string[] args)
        {
            
        }
        // https://www.geek-share.com/detail/2641904182.html
        static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode fakeNode = new ListNode(-1);

            ListNode result = fakeNode;
            ListNode pre = head;
            ListNode cur = head;
            while (cur != null && cur.next != null)
            {
                while (cur.next != null && cur.next.val == pre.val)
                    cur = cur.next;
                if (cur == pre)
                {
                    result.next = pre;
                    result = result.next;
                }
                pre = cur.next;
                cur = cur.next;
            }
            result.next = cur;
            return fakeNode.next;
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
    }
