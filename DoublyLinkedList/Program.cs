using System;

namespace DoublyLinkedList
{
    class Node
    {
        /*Node class represent the node of doubly linked list.
         * * It consists of the information part and liks to
         * Its succeeding and preceeding nodes
         * In term of next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding nodr*/
        public Node prev;/*points to the preceeding node*/
    }
}

