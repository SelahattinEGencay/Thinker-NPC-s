using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Default Info", menuName = "Information System/Information/Default")]

public class DefaultObject : InfoObject
{
    public void Awake()
    {
        type = InfoType.Default;
    }
}
