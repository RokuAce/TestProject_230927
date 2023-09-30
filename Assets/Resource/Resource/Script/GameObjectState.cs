using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectState : MonoBehaviour
{
    public List<Equipment> EquipmentList= new List<Equipment>();

    public float CountMultiplier(Data data)
    {
        float temp = 0;
        for (int i = 0; i < EquipmentList.Count; i++)
        {
            temp+=EquipmentList[i].DataList[data];
        }
        return temp;
    }
}
