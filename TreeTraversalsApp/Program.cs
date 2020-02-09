using System;

namespace TreeTraversalsApp
{
    class Program
    {
        public static Node nodeCreated;

        public static void CreateTree()
        {
            Node root = new Node("A");
            root.left = new Node("B");
            root.right = new Node("C");
            root.left.left = new Node("D");
            root.left.right = new Node("E");
            root.left.right.left = new Node("F");
            nodeCreated = root;
        }

        public static void PreOrderTraversall(Node node)
        {
            if (node == null) return;

            //print root
            Console.Write(node.Data + " ");

            //pre order
            PreOrderTraversall(node.left);

            //post ordre
            PreOrderTraversall(node.right);
        }

        public static void PostOrderTraversall(Node node)
        {
            if (node == null) return;

            //pre order
            PostOrderTraversall(node.left);

            //post ordre
            PostOrderTraversall(node.right);

            //print root
            Console.Write(node.Data + " ");
        }

        public static void InOrderTraversall(Node node)
        {
            if (node == null) return;

            //pre order
            InOrderTraversall(node.left);

            //print root
            Console.Write(node.Data + " ");

            //post ordre
            InOrderTraversall(node.right);

    
        }

        static void Main(string[] args)
        {
            CreateTree();
            Console.WriteLine("Pre order:");
            PreOrderTraversall(Program.nodeCreated);
            Console.WriteLine("");
            Console.WriteLine("In order:");
            InOrderTraversall(Program.nodeCreated);
            Console.WriteLine("");
            Console.WriteLine("Post order:");
            PostOrderTraversall(Program.nodeCreated);
            Console.ReadLine();
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public string Data { get; set; }

        public Node(string data)
        {
            this.Data = data;
        }
    }


}
