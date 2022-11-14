using System;
using System.Text;

namespace LinkedLists
{
    /// <remarks>
    /// A linked list of a data type
    /// </remarks>
    abstract class LinkedList<T>
    {
        protected LinkedListNode<T> head;
        protected int count;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        protected LinkedList()
        {
            head = null;
            count = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of nodes in the list
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Gets the head of the list
        /// </summary>
        /// <value>head of the list</value>
        public LinkedListNode<T> Head
        {
            get { return head; }
        }

        #endregion

        #region Public methods

        public abstract void Add(T item);

        /// <summary>
        /// Removes all the items from the linked list
        /// </summary>
        public void Clear()
        {
            // unlink all nodes so they can be garbage collected
            if (head != null)
            {
                LinkedListNode<T> previousNode = head;
                LinkedListNode<T> currentNode = head.Next;
                previousNode.Next = null;
                while (currentNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                    previousNode.Next = null;
                }
            }

            // reset head and count
            head = null;
            count = 0;
        }

        /// <summary>
        /// Removes the given item from the list
        /// </summary>
        /// <param name="item">item to remove</param>
        public bool Remove(T item)
        {
            if (head == null) {
                return false; // Nic do roboty, pusta lista
            }
            else if (head.Value.Equals(item)) {
                head = head.Next; // `head` jest szukanym elementem
                count--;
                return true;
            }

            // Spróbuj znaleźć element
            LinkedListNode<T> curr = head;
            while (curr != null && !curr.Value.Equals(item)) {
                curr = curr.Next;
            }

            if (curr == null)
                return false; // Nie można znaleźć elementu do wywalenia

            if (curr.Previous != null)
                curr.Previous.Next = curr.Next;

            if (curr.Next != null)
                curr.Next.Previous = curr.Previous;
            return true;
        }

        /// <summary>
        /// Finds the given item in the list. Returns null
        /// if the item wasn't found in the list
        /// </summary>
        /// <param name="item">item to find</param>
        public LinkedListNode<T> Find(T item)
        {
            LinkedListNode<T> currentNode = head;
            while (currentNode != null &&
                !currentNode.Value.Equals(item))
            {
                currentNode = currentNode.Next;
            }

            // return node for item if found
            if (currentNode != null)
            {
                return currentNode;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the linked list to a comma-separated string of values
        /// </summary>
        /// <returns>comma-separated string of values</returns>
        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            LinkedListNode<T> currentNode = head;
            int nodeCount = 0;
            while (currentNode != null)
            {
                nodeCount++;
                builder.Append(currentNode.Value);
                if (nodeCount < count)
                {
                    builder.Append(",");
                }
                currentNode = currentNode.Next;
            }
            return builder.ToString();
        }
   
        public void PrintList() {
            LinkedListNode<T> node = head;
            if (node == null)
                Console.WriteLine("The list is empty");

            while (node != null) {
                Console.Write("Current: {0}, ", node.Value);

                if (node.Next != null)
                    Console.Write("Next: {0}, ", node.Next.Value);
                else
                    Console.Write("Next: (none), ");

                if (node.Previous != null)
                    Console.Write("Prev: {0}\n", node.Previous.Value);
                else
                    Console.Write("Prev: (none)\n");

                node = node.Next;
            }
        }
        #endregion
    }
}