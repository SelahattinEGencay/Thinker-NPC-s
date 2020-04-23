using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Skill Info", menuName = "Information System/Information/Skill")]

public class SkillsObject : InfoObject
{
    public float Skill;
    public int Skillvalue;

    public void Awake()
    {
        type = InfoType.Skills;
    }
}
