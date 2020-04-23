using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InfoType
{
    Resource,
    People,
    Skills,
    Default
}

public class InfoObject : ScriptableObject
{
    public GameObject prefab;
    public InfoType type;
    [TextArea(15, 20)]
    public string description;
}
