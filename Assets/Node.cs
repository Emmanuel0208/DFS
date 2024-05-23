using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    private bool _visited;
    private float _value;
    private List<Edge> _edges;

    public Node()
    {
        _visited = false;
        _value = 0;
        _edges = new List<Edge>();
    }

    public Node(float val)
    {
        _visited = false;
        _value = val;
        _edges = new List<Edge>();
    }

    public void AddEdge(ref Edge edge)//set
    {
        _edges.Add(edge);
    }

    public void SetVisited(bool visited)
    {
        _visited = visited;
    }

    public bool GetVisited()
    {
        return _visited;
    }

    public List<Edge> GetEdges()
    {
        return _edges;
    }

    public void SetValue(float val)
    {
        _value = val;
    }

    public float GetValue()
    {
        return _value;
    }
}
