using System.Security.Cryptography;

Solution solution = new Solution();
solution.IsPalindrome("A man, a plan, a canal: Panama");



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