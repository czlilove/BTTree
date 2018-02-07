using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTNode
{
    public List<BTNode> children;
    public virtual BTNodeStatus Execute()
    {
        return BTNodeStatus.Suceesss;
    }

    public void AddChild(BTNode child)
    {
        children.Add(child);
    }
}
