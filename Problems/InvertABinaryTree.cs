// Given the root of a binary tree, invert the tree, and return its root.

public partial class Solution{
    public TreeNode InvertTree(TreeNode root) {
        if(root==null)return root;
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }

    public TreeNode InvertTreeTwo(TreeNode root) {
        if(root==null) return root;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var curr = q.Dequeue();
            var temp = curr.left;
            curr.left = curr.right;
            curr.right = temp;
            if(curr.left!=null)q.Enqueue(curr.left);
            if(curr.right!= null)q.Enqueue(curr.right);
        }
        return root;
    }
}