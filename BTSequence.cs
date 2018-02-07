using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTSequence : BTNode
{
    BTNode currentNode;
    int index = 0;
    public override BTNodeStatus Execute()
    {
        if(currentNode == null)
        {
            currentNode = children[0];
            index = 0;
        }
        if (currentNode.Execute() == BTNodeStatus.Suceesss)
        {
            index++;
            if (index>=children.Count)
            {
                return BTNodeStatus.Suceesss;
            }
            else
            {
                currentNode = children[index];
                return BTNodeStatus.Running;
            }
        }
        else
            return BTNodeStatus.Fail;
    }
}
