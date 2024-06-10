using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtrathuchanh
{
    class Node
    {
        public Object Value;
        public int key;
        public Node left;
        public Node right;
        

        public Node()
        {
            Value = null;
            left = null;
            right = null;
        }

        public Node(int aKey)
        {
            left = null;
            right = null;
            Value = aKey;
            key = aKey;
        }
    }
}
