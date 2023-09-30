using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_StateText : MonoBehaviour
{
    public VariableGameObject CurrentObject;
    string Name = "";
    Material Current_Mat;
    Transform Current_Trans;

    void StateUpdate()
    {
        Name = CurrentObject.ThisObject.name;
        Current_Mat = CurrentObject.ThisObject.GetComponent<MeshRenderer>().material;
        Current_Trans = CurrentObject.ThisObject.transform;
        TextUpdate();
    }

    TextMeshProUGUI TMP;
    void TextUpdate()
    {
        string State = "Current Object:" + Name + "<br> Current Color:" + Current_Mat.GetColor("_Color") + "<br> Current Scale:" + Current_Trans.localScale;
        TMP.text = State;
    }

    private void Start()
    {
        TMP = this.GetComponent<TextMeshProUGUI>();
        StateUpdate();
    }
}
