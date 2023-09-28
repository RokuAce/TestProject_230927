using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    public GameObject Object;

    private void Start() {
         Material Mat = Object.GetComponent<MeshRenderer>().material;
         Mat.SetColor("_Color",Color.black);   
    }
    public void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            MakeRed(Object);
        }
    }
    public void MakeRed(GameObject Object){
        Material Mat = Object.GetComponent<MeshRenderer>().material;
        var NewRed = Mat.color.r;
        
        if(NewRed != 1){
            NewRed = NewRed + 0.1f;
            Mat.SetColor("_Color", new Color(NewRed, Mat.color.g, Mat.color.b));
        }
        
        

    }
}
