﻿using EventBinder;
using UnityEngine;

public class EventBinderSampleListenerController : MonoBehaviour {

    
    
	// Use this for initialization
    private void Start ()
    {
        EventsCollection.eventEmpty           += OnEventEmptyHandler;
	    EventsCollection.eventWithStringArgs  += OnEventWithStringArgsHandler;
	    EventsCollection.eventWithNumbersArgs += OnEventWithNumberArgsHandler;
	    EventsCollection.eventWithVectorsArgs += OnEventWithVectorsARgsHandler;
	    EventsCollection.eventWithGoArgs      += OnEventWithGoArgsHandler;
	}
    
    
    
    
    /**EVENT HANDLERS*/
    public void OnEventEmptyHandler()
    {
        Debug.Log ("We got a new message ");
    }
    
    public void OnEventWithStringArgsHandler(string value)
    {
        Debug.Log ("We got a new message with a String parameter: " + value);
    }
    
    public void OnEventWithNumberArgsHandler(int intValue, float floatValue, double doubleValue)
    {
        Debug.Log ("We got a new message with Number type parameters: " + intValue + " | " + doubleValue);
    }
    
    public void OnEventWithVectorsARgsHandler(Vector2 v2Value, Vector3 v3Value, Vector4 v4Value)
    {
        Debug.Log ("We got a new message with Vector type parameters: " + v2Value + " | " + v3Value + " | " + v4Value);
    }
    
    public void OnEventWithGoArgsHandler(GameObject gameObjectValue, Component componentValue)
    {
        Debug.Log ("We got a new message with a GameObject and a Component parameter: " + gameObjectValue + " | " + componentValue);
    }
}
