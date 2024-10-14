namespace LinkedArrayTiba
{
    internal class Node<T>
    {
        public T Value;
        public Node<T> Child;
        public Node<T> Parent;

        public Node(T value)
        {
            Value = value;
        }
    }
}
