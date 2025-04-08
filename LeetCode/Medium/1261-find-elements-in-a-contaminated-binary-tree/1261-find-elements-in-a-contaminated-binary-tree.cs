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
public class FindElements {
    List<int> nodeVal = new List<int>();
    public FindElements(TreeNode root) {
        Recover(root, 0);
    }
    
    public bool Find(int target) {
        return nodeVal.Contains(target);
    }

    public void Recover(TreeNode node, int x){
        if(node == null) return;

        nodeVal.Add(x);
        node.val = x;

        Recover(node.left, 2*x+1);
        Recover(node.right, 2*x+2);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */