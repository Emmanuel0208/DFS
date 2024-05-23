using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void Initialize()
    {
        Node node1 = new Node(3);
        Node node2 = new Node(3);
        Node node3 = new Node(2);
        Node node4 = new Node(10);
        Node node5 = new Node(5);
        Node node6 = new Node(4);

        Edge egde13 = new Edge(ref node1, ref node3);

        node1.AddEdge(ref egde13);
        node3.AddEdge(ref egde13);

        Graph graph = new Graph();
        graph.AddNode(node1);
    }
}