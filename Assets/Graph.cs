using System.Collections.Generic;

public class Graph
{
    private List<Node> nodes = new List<Node>();   // Lista de nodos en el grafo
    private List<Edge> edges = new List<Edge>();   // Lista de bordes en el grafo

    // Agrega un nodo al grafo
    public void AddNode(Node newNode)
    {
        nodes.Add(newNode);
    }

    // Agrega un borde al grafo
    public void AddEdge(Edge newEdge)
    {
        edges.Add(newEdge);
    }

    // Devuelve la lista de nodos en el grafo
    public List<Node> GetNodes()
    {
        return nodes;
    }

    // Devuelve la lista de bordes en el grafo
    public List<Edge> GetEdges()
    {
        return edges;
    }
}
