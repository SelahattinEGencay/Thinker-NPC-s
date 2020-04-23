using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New People Info", menuName = "Information System/Information/People")]

public class PeopleObject : InfoObject
{
    public int Affinity;
    public int Reputation;
    public int Goal;

    public void Awake()
    {
        type = InfoType.People;
    }
}
