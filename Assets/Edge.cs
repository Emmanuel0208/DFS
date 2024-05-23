public class Edge
{
    private Node _node1;        // Primer nodo conectado por el borde
    private Node _node2;        // Segundo nodo conectado por el borde
    private float _distance;    // Distancia entre los nodos (opcional)

    // Constructor de la clase Edge
    // Recibe dos nodos y opcionalmente una distancia entre ellos
    public Edge(Node one, Node two, float distance = 0.0f)
    {
        _node1 = one;         // Asigna el primer nodo recibido
        _node2 = two;         // Asigna el segundo nodo recibido
        _distance = distance; // Asigna la distancia recibida
    }

    // Devuelve el primer nodo conectado por el borde
    public Node GetNode1()
    {
        return _node1;
    }

    // Establece el primer nodo conectado por el borde
    public void SetNode1(Node node1)
    {
        _node1 = node1;
    }

    // Devuelve el segundo nodo conectado por el borde
    public Node GetNode2()
    {
        return _node2;
    }

    // Establece el segundo nodo conectado por el borde
    public void SetNode2(Node node2)
    {
        _node2 = node2;
    }

    // Devuelve la distancia entre los nodos conectados por el borde
    public float GetDistance()
    {
        return _distance;
    }

    // Establece la distancia entre los nodos conectados por el borde
    public void SetDistance(float distance)
    {
        _distance = distance;
    }

    // Verifica si el borde contiene un nodo dado
    // Devuelve true si el borde conecta con el nodo dado
    public bool Contains(Node node)
    {
        return _node1 == node || _node2 == node;
    }
}
