using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Prefab para los nodos
    public GameObject nodePrefab;
    // Máximo número de bordes por nodo
    public int maxEdgesPerNode = 3;
    // Grafo que contiene los nodos y los bordes
    private Graph graph;
    //nodos
    public int nodes_;
    //primer distancia
    public int minDistance;
    //segunda distancia
    public int maxDistance;

    void Start()
    {
        // Inicializa el grafo
        graph = new Graph();
        // Inicializa los nodos
        InitializeNodes();
        // Inicializa los bordes
        InitializeEdges();
    }

    // Crea nodos en posiciones aleatorias
    void InitializeNodes()
    {
        for (int i = 0; i < nodes_; i++)
        {
            // Obtiene una posición aleatoria
            Vector3 position = GetRandomPosition();
            // Instancia un nuevo nodo a partir del prefab y la posición
            GameObject newNodeObject = Instantiate(nodePrefab, position, Quaternion.identity);
            // Crea un nuevo nodo con el GameObject instanciado
            Node newNode = new Node(newNodeObject);
            // Agrega el nodo al grafo
            graph.AddNode(newNode);
        }
    }

    // Inicializa los bordes entre nodos cercanos
    void InitializeEdges()
    {
        // Obtiene la lista de nodos del grafo
        List<Node> nodes = graph.GetNodes();

        foreach (Node currentNode in nodes)
        {
            // Encuentra los nodos más cercanos al nodo actual
            List<Node> nearestNodes = FindNearestNodes(currentNode, maxEdgesPerNode);

            foreach (Node nearestNode in nearestNodes)
            {
                // Crea un nuevo borde entre el nodo actual y el nodo más cercano
                Edge newEdge = new Edge(currentNode, nearestNode);
                // Agrega el borde a ambos nodos
                currentNode.AddEdge(newEdge);
                nearestNode.AddEdge(newEdge); // Para un grafo no dirigido
                // Agrega el borde al grafo
                graph.AddEdge(newEdge); // Agregar el borde a la lista de bordes en Graph
            }
        }
    }

    // Encuentra los nodos más cercanos a un nodo dado
    List<Node> FindNearestNodes(Node node, int count)
    {
        // Obtiene una copia de la lista de nodos del grafo
        List<Node> allNodes = new List<Node>(graph.GetNodes());
        // Remueve el nodo actual de la lista
        allNodes.Remove(node);

        // Obtiene la posición del nodo actual
        Vector3 currentNodePosition = node.GetGameObject().transform.position;

        // Ordena los nodos por distancia al nodo actual
        allNodes.Sort((a, b) => Vector3.Distance(currentNodePosition, a.GetGameObject().transform.position)
                        .CompareTo(Vector3.Distance(currentNodePosition, b.GetGameObject().transform.position)));

        // Devuelve los primeros "count" nodos más cercanos
        return allNodes.GetRange(0, Mathf.Min(count, allNodes.Count));
    }

    // Obtiene una posición aleatoria en el espacio tridimensional
    Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-minDistance, maxDistance), 0f, Random.Range(-minDistance, maxDistance));
    }

    // Dibuja los bordes entre los nodos en el editor de Unity
    void OnDrawGizmos()
    {
        if (graph == null) return;

        List<Node> nodes = graph.GetNodes();
        if (nodes == null) return;

        foreach (Node node in nodes)
        {
            List<Edge> edges = node.GetEdges();
            if (edges == null) continue;

            foreach (Edge edge in edges)
            {
                GameObject node1Object = edge.GetNode1()?.GetGameObject();
                GameObject node2Object = edge.GetNode2()?.GetGameObject();

                if (node1Object != null && node2Object != null)
                {
                    // Dibuja una línea entre los nodos conectados
                    Vector3 start = node1Object.transform.position;
                    Vector3 end = node2Object.transform.position;
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(start, end);
                }
            }
        }
    }

}
