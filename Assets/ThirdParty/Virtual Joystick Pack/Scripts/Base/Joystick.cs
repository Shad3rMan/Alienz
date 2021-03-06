﻿using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    [Header("Options")]
    [SerializeField]
    [Range(0f, 2f)] protected float handleLimit = 1f;

    protected Vector2 inputVector = Vector2.zero;

    [Header("Components")]
    [SerializeField]
    protected RectTransform background;
    [SerializeField]
    protected RectTransform handle;

    public float Horizontal { get { return inputVector.x; } }
    public float Vertical { get { return inputVector.y; } }

    public virtual void OnDrag(PointerEventData eventData)
    {

    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {

    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {

    }
}
