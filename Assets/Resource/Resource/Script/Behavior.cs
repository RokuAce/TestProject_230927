using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Behavior:ScriptableObject
{
    public VariableGameObject CurrentObject;

    public void Update() {
        //ด๚ธี
        /*
        if (Input.GetKeyDown(KeyCode.Space)){
            print("Key is down");
            MakeRed(CurrentObject.ThisObject);
        }
        */
    }

    public void SetCurrentObject(GameObject TargetObject)
    {
        CurrentObject.ThisObject = TargetObject;
    }
    public void MakeRed()
    {
        Material Mat = CurrentObject.ThisObject.GetComponent<MeshRenderer>().material;
        var NewRed = Mat.color.r;
        
        if (NewRed != 1){
            NewRed = NewRed + 0.1f;
            Mat.SetColor("_Color", new Color(NewRed, Mat.color.g, Mat.color.b));
            
        }
    }
    public void MakeFlat()
    {
        Transform Trans = CurrentObject.ThisObject.GetComponent<Transform>();
        var NewScale = Trans.localScale.y;

        if (NewScale > 0.1)
        {
            Vector3 scaleChange = new Vector3(0, -0.1f, 0);
            Trans.localScale += scaleChange;

        }
    }
}
