using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTTree 
{
    BTNode root;
    public BTTree(BTNode root)
    {
        this.root = root;
    }

    public void Run()
    {
        root.Execute();
    }
}
