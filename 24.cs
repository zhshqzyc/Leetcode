public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode curr, last, temp, newhead;
            last = head;
            curr = head.next;
            newhead = head.next;
            while (curr != null)
            {
                temp = curr.next;
                curr.next = last;
                last.next = temp;
                if (temp == null || temp.next == null) return newhead;
                else
                {
                    last.next = temp.next;
                    curr = temp.next;
                    last = temp;
                }
            }
            return newhead;
        }
