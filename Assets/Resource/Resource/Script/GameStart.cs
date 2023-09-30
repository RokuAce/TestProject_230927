using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public VariableGameObject CurrentObject;
    public GameObject InitGameObject;
    void Start()
    {
        CurrentObject.ThisObject = InitGameObject;
    }

}
