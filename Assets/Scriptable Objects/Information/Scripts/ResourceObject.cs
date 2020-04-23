using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Resource Info", menuName = "Information System/Information/Resource")]
public class ResourceObject : InfoObject
{
    public int X_coordinate;
    public int Y_coordinate;
    public int collectAmount;

    public void Awake()
    {
        type = InfoType.Resource;
    }
}
