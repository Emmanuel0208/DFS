using System.Collections.Generic;
using UnityEngine;

public class Node
{
    private bool _visited;             // Indica si el nodo ha sido visitado
    private float _value;              // Valor asociado al nodo (opcional)
    private List<Edge> _edges;         // Lista de bordes conectados al nodo
    private GameObject _gameObject;    // Referencia al GameObject asociado al nodo

    // Constructor que acepta un GameObject para asociar al nodo
    public Node(GameObject gameObject)
    {
        _visited = false;
        _value = 0;
        _edges = new List<Edge>();
        _gameObject = gameObject;  // Asigna el GameObject recibido al nodo
    }

    // Constructor alternativo para nodos sin GameObject asociado
    public Node(float val)
    {
        _visited = false;
        _value = val;
        _edges = new List<Edge>();
    }

    // Agrega un borde conectado al nodo
    public void AddEdge(Edge edge)
    {
        _edges.Add(edge);
    }

    // Establece si el nodo ha sido visitado o no
    public void SetVisited(bool visited)
    {
        _visited = visited;
    }

    // Obtiene el estado de visitado del nodo
    public bool GetVisited()
    {
        return _visited;
    }

    // Obtiene la lista de bordes conectados al nodo
    public List<Edge> GetEdges()
    {
        return _edges;
    }

    // Establece el valor del nodo
    public void SetValue(float val)
    {
        _value = val;
    }

    // Obtiene el valor del nodo
    public float GetValue()
    {
        return _value;
    }

    // Establece el GameObject asociado al nodo
    public void SetGameObject(GameObject obj)
    {
        _gameObject = obj;
    }

    // Obtiene el GameObject asociado al nodo
    public GameObject GetGameObject()
    {
        return _gameObject;
    }
}
