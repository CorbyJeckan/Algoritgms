namespace Thread2447455
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data) //sd
        {
            Data = data;
        }

        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
}