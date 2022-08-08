namespace LinkedList
{
    public class Node
    {
        private string _value;

        private Node _prev;
        private Node _next;

        public string Value
        {
            get => _value;
            private set 
            {
                _value = value;
            }
        }

        public Node Prev
        {
            get => _prev;
            private set
            {
                _prev = value;
            }
        }

        public Node Next
        {
            get => _next;
            private set
            {
                _next = value;
            }
        }

        public Node(string value)
        {
            Value = value;
        }
    }
}
