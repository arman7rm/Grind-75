using System.Security.Cryptography;

Solution solution = new Solution();
var a = new ListNode(1);
a.Add(2);
a.Add(4);
var b = new ListNode(1);
b.Add(3);
b.Add(4);
b.Add(5);
var res = solution.MergeTwoLists(a,b);
while(res!=null){
    Console.Write(res.val + " -> ");
    res = res.next;
}



public class ListNode{
    public int val;
    public ListNode next;

    public ListNode(int v){
        val = v;
        next = null;
    }

    public void Add(int v){
        if(next==null){
            next = new ListNode(v);
        }else{
            next.Add(v);
        }
    }
}