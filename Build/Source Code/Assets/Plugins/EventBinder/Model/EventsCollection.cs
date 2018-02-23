﻿using System;
using UnityEngine;

namespace EventBinder
{
    public static class EventsCollection
    {
        //GENERAL
        
        //SAMPLE
        public static event Action eventEmpty = delegate { };
        
        public static event Action<string> eventWithStringArgs = delegate (string testValue) {};

        public static event Action<int, float, double> eventWithNumbersArgs = delegate(int intValue, float floatArg, double doubleArg) { };
        public static event Action<Vector2, Vector3, Vector4> eventWithVectorsArgs = delegate(Vector2 v2Value, Vector3 v3Value, Vector4 v4Value) { };
        public static event Action<GameObject, Component> eventWithGoArgs = delegate(GameObject gameObjectValue, Component componentValue) { };
    }
}