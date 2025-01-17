using System;
using System.Collections.Generic;
using System.Text;

// Define the Node class to represent each node in the binary tree
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

// Define the BinaryTree class to represent a binary tree
class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    // The function traverses the binary tree in post-order
    public void PostOrderTraversal(Node node)
    {
        if (node == null)
        {
            return;
        }

        // Browse the subtree on the left
        PostOrderTraversal(node.Left);

        // Browse the subtree on the right
        PostOrderTraversal(node.Right);

        // Process the current node
        Console.Write(node.Data + " ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a sample binary tree
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
