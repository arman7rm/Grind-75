using System.Security.Cryptography;

Solution solution = new Solution();
solution.IsPalindrome("A man, a plan, a canal: Panama");



static void PrintTree(TreeNode n){
    if(n!=null){
        PrintTree(n.left);
        Console.Write(n.val+", ");
        PrintTree(n.right);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int v)
    {
        val = v;
        next = null;
    }

    public void Add(int v)
    {
        if (next == null)
        {
            next = new ListNode(v);
        }
        else
        {
            next.Add(v);
        }
    }
}