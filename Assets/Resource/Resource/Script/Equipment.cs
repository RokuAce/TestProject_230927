using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Data { Red, Scale }
[CreateAssetMenu]
public class Equipment : ScriptableObject
{
    public GameObject EquipmentPrefab;
    public float Red = 0;
    public float Scale = 0;
    
    public Dictionary<Data, float> DataList = new Dictionary<Data, float>();

    Equipment()
    {
        DataList.Add(Data.Red, Red);
        DataList.Add(Data.Scale, Scale);
    }
}
