using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrathuchanh
{
    class BinarySearchTree
    {
        public Node root;
        public void PreOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.left);
                PreOrder(aRoot.right);
            }
        }
        //Câu 1
        public void hienthi()
        {
            Console.WriteLine("Cay tim kiem nhi phan:");
            hienthimanhinh(root);
        }

        private void hienthimanhinh(Node root)
        {
            if (root != null)
            {
                hienthimanhinh(root.right);
                Console.Write(root.key + " ");
                hienthimanhinh(root.left);
            }
        }
        public bool Add(int x)
        {
            bool result = true;
            Node newNode = new Node(x);
            if (root == null)
            {
                root = newNode;
                return result;
            }
            Node curNode = root;
            Node parentNode;
            while (true)
            {
                parentNode = curNode;
                if (x == curNode.key)
                {
                    result = false;
                    break;
                }
                if (x < curNode.key)
                {
                    curNode = curNode.left;
                    if (curNode == null)
                    {
                        parentNode.left = newNode;
                        break;
                    }
                }
                else
                {
                    curNode = curNode.right;
                    if (curNode == null)
                    {
                        parentNode.right = newNode;
                        break;
                    }
                }
            }
            return result;
        }
        //câu 2
        public int FindMax(Node aRoot)
        {
            int Max = aRoot.key;
            if (aRoot.right == null)
                return Max;
            else
                return FindMax(aRoot.right);
        }
        //câu 3
        public double demnutle(Node root)
        {
            int n = 0;
            Node curNode = root;
            while (curNode != null)
            {
                if ((int)curNode.Value % 2 != 0)
                n++;
                curNode = curNode.right;
            }
            return n;
        }
     
        //câu 5
        public void PostOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                PostOrder(aRoot.left);
                PostOrder(aRoot.right);
                Process(aRoot);
            }
        }
        public void Display(Node node)
        {
            if (node != null)
                Console.Write(node.key.ToString() + " ");
            else
                Console.Write("null" + " ");
        }

        public void Process(Node node)
        {
            Display(node);
        }
        public bool Remove(int x)
        {
            Node curNode = root;
            Node parentNode = root;
            bool isLeftChild = true;
            while (curNode.key != x)
            {
                parentNode = curNode;
                if (x < curNode.key)
                {
                    isLeftChild = true;
                    curNode = curNode.left;
                }
                else
                {
                    isLeftChild = false;
                    curNode = curNode.right;
                }
                if (curNode == null)
                    return false;
            }

            if ((curNode.left == null) && (curNode.right == null))
            {
                if (curNode == root)
                    root = null;
                else if (isLeftChild)
                    parentNode.left = null;
                else
                    parentNode.right = null;
            }
            else if (curNode.right == null)
            {
                if (curNode == root)
                    root = null;
                else if (isLeftChild)
                    parentNode.left = curNode.left;
                else
                    parentNode.right = curNode.left;
            }
            else if (curNode.left == null)
            {
                if (curNode == root)
                    root = curNode.right;
                else if (isLeftChild)
                    parentNode.left = curNode.right;
                else
                    parentNode.right = curNode.right;
            }
            else
            {
                Node subsNode = GetSubsNode(curNode);
                if (curNode == root)
                    root = subsNode;
                else if (isLeftChild)
                    parentNode.left = subsNode;
                else
                    parentNode.right = subsNode;
                subsNode.left = curNode.left;
            }
            return true;
        }
        public Node GetSubsNode(Node removeNode)
        {
            Node subsParent = removeNode;
            Node subsNode = removeNode;
            Node curNode = removeNode.right;
            while (curNode != null)
            {
                subsParent = subsNode;
                subsNode = curNode;
                curNode = curNode.left;
            }
            if (subsNode != removeNode.right)
            {
                subsParent.left = subsNode.right;
                subsNode.right = removeNode.right;
            }
            return subsNode;
        }
    }
}
