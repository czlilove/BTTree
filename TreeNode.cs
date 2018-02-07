using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeNode<T> 
{
    List<TreeNode<T>> children;
    TreeNode<T> parent;
    int degree;

    T data;


    public void AddChild(TreeNode<T> node)
    {
        children.Add(node);
    }

    public void RemoveChild(TreeNode<T> node)
    {
        children.Remove(node);
    }
}
