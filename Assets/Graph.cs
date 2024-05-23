using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    private List<Node> nodes = new List<Node>();

    public Graph()
    {
        nodes = new List<Node>();
    }

    public Graph(ref List<Node> listNodes)
    {
        nodes = listNodes;
    }

    public void AddNode(Node newNode)
    {
        nodes.Add(newNode);
    }


}