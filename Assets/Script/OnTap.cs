using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class OnTap : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public UnityEvent onTap = new UnityEvent();
    public float tapThoreshold = 0.1f;
    float pushTime = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        pushTime = Time.time;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (Time.time - pushTime < tapThoreshold)
            onTap.Invoke();
    }
}
