using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public StorageObject storage;

    public void OnTriggerEnter(Collider other)
    {
        var info = other.GetComponent<Info>();
        if (info)
        {
            storage.AddInfo(info.info, 1);
        }
    }
    private void OnApplicationQuit()
    {
        storage.Container.Clear();
    }
}
