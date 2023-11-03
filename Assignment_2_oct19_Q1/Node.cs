namespace Assignment_2_oct19_Q1
{
    internal class Node<T> 
    {
        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }


    }
}