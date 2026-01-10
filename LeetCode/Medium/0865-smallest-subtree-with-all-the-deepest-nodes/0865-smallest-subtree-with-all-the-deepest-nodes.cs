/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public class Node{
        public TreeNode node;
        public int depth;

        public Node(TreeNode node, int depth){
            this.node = node;
            this.depth = depth;
        }
    }

    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        return DFS(root).node;
    }

    public Node DFS(TreeNode root){
        if(root == null) return new Node(null, 0);

        Node ln = DFS(root.left);
        Node rn = DFS(root.right);

        if(ln.depth>rn.depth) return new Node(ln.node, ln.depth+1);
        if(rn.depth>ln.depth) return new Node(rn.node, rn.depth+1);

        return new Node(root, ln.depth+1);
    }

}