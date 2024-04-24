using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
    [Header("Scene")]
    public Transform selectionTransform = null;
    public Transform cursorTransform = null;

    [Header("Events")]
    public RadialSection top = null;
    public RadialSection right = null;
    public RadialSection bottom = null;
    public RadialSection left = null;

    private Vector2 touchPosition = Vector2.zero;
    private List<RadialSection> radialSelection = null;
    private RadialSection highlightedSection = null;

    private readonly float degreeIncrement = 90.0f;

    private void Start()
    {
        Show(false);
    }
    public void Show(bool value)
    {
        gameObject.SetActive(value);
    }

    private void Update()
    {
        Vector2 direction = Vector2.zero + touchPosition;
        float rotation = GetDegree(direction);

        SetCursorPosition();
    }
    private float GetDegree(Vector2 direction)
    {
        float value = Mathf.Atan2(direction.x, direction.y);
        value *= Mathf.Rad2Deg;

        if (value < 0)
            value += 360.0f;

        return value;
    }

    private void SetCursorPosition()
    {
        cursorTransform.localPosition = touchPosition;
    }
    public void SetTouchPosition(Vector2 newVa1ue)
    {
        touchPosition = newVa1ue;
    }

}
