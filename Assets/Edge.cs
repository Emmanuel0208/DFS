using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge
{
    Node _node1;
    Node _node2;
    float _distance;

    public Edge(ref Node one, ref Node two)
    {
        _node1 = one;
        _node2 = two;



    }
    public Node Node1()
    {
        return _node1;

    }

    public void SetNum1(ref Node node1)
    {
        _node1 = node1;
    }

    public Node Node2()
    {
        return _node2;

    }

    public void SetNum2(ref Node node2)
    {
        _node2 = node2;
    }

}