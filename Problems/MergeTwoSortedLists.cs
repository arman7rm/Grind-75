public partial class Solution{

    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1.val>list2.val){
            return MergeTwoLists(list2,list1);
        }
        ListNode dummyHead = new ListNode(0);
        var runner = dummyHead;
        while(list1!=null && list2!=null){
            if(list1.val<list2.val){
                runner.next = list1;
                list1 = list1.next;
            }else{
                runner.next = list2;
                list2 = list2.next;
            }
            runner = runner.next;
        }
        while(list1!=null){
            runner.next = list1;
            list1 = list1.next;
            runner = runner.next;
        }
        while(list2!=null){
            runner.next = list2;
            list2 = list2.next;
            runner = runner.next;
        }
        return dummyHead.next;
    }

}