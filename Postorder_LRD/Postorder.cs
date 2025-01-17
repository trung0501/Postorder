using System;

// Định nghĩa lớp Node biểu diễn mỗi nút trong cây nhị phân
class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

// Định nghĩa lớp BinaryTree để biểu diễn cây nhị phân
class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    // Hàm duyệt cây nhị phân theo thứ tự post-order
    public void PostOrderTraversal(Node node)
    {
        if (node == null)
        {
            return;
        }

        // Duyệt cây con bên trái
        PostOrderTraversal(node.Left);

        // Duyệt cây con bên phải
        PostOrderTraversal(node.Right);

        // Xử lý nút hiện tại
        Console.Write(node.Data + " ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo một cây nhị phân mẫu
        BinaryTree tree = new BinaryTree();

        /*
                Cây mẫu:
                    1
                   / \
                  2   3
                 / \
                4   5
        */

        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);

        // Post-order traversal
        Console.WriteLine("Post-order traversal of the binary tree:");
        tree.PostOrderTraversal(tree.Root);
    }
}
