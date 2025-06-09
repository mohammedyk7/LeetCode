public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;
        //Each list represents a number in reverse

        while (l1 != null || l2 != null || carry != 0) {
            int sum = carry;
            //we can use int sum =0

            if (l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            int digit = sum % 10;

            current.next = new ListNode(digit);
            current = current.next;
        }

        return dummyHead.next;    //dummyHead itself is just a placeholder (value = 0, ignored)
    } // this is just a test push
   

}
