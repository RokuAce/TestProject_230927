using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable() {
        Event.RegisterListner(this);    
    }
    private void OnDisable() {
        Event.UnRegisterListner(this);
    }
    public void OnEventRaised(){
        Response.Invoke();
    }
}
