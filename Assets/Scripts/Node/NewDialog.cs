using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class Dialog : Node
{
    [SerializeField] private string _name;
    [SerializeField][TextArea(5, 10)] private string _text;
    // Use this for initialization
    public string Name => _name;
    public string Text => _text;
    protected override void Init()
    {
        base.Init();

    }

    // Return the correct value of an output port when requested
    public override object GetValue(NodePort port)
    {
        return null; // Replace this
    }
}