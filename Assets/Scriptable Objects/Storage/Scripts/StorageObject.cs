using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Storage", menuName = "Information System/Storage")]

public class StorageObject : ScriptableObject
{
    public List<StorageSlot> Container = new List<StorageSlot>();
    public void AddInfo(InfoObject _info, int _amount)
    {
        if(Container.Count == 0)
        {
            Container.Add(new StorageSlot(_info, _amount));
            return;
        }

        bool hasInfo = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].info == _info)
            {
                Container[i].AddAmount(_amount);
                hasInfo = true;
                break;
            }
        }
        if (!hasInfo)
        {
            Container.Add(new StorageSlot(_info, _amount));
        }
    }
}

[System.Serializable]
public class StorageSlot
{
    public InfoObject info;
    public int amount;
    public StorageSlot(InfoObject _info, int _amount)
    {
        info = _info;
        amount = _amount;
    }
    public void AddAmount(int value)
    {
        amount += value;
    }
}
