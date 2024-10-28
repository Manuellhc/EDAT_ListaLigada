namespace ListaLigada.Logica
{
    public class SingleNode<T>
    {
        public T? Data { get; set; }
        public SingleNode<T>? Next { get; set; }

        public SingleNode(T data)
        {
            data = data;
            Next = null;
        }
    } 

    
}
