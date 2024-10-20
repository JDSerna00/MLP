using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour,IClickable
{
    public float startRotationSpeed = 100f;
    public float currentRotationSpeed;
    public float decelerationRate = 5f;
    public bool isRotating;
    private void Start()
    {
        isRotating = true;
        currentRotationSpeed = startRotationSpeed;
    }
    void Update()
    {
        if (isRotating)
        {
            Rotate();
        }
        else {
            StopRotating();
        }
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, startRotationSpeed * Time.deltaTime, Space.Self);
    }
    private void StopRotating()
    {
        currentRotationSpeed = decelerationRate * Time.deltaTime;
        transform.Rotate(Vector3.up, currentRotationSpeed * Time.deltaTime, Space.Self);
    }
    public void OnClick()
    {
        Debug.Log("touched rotator");
        isRotating = !isRotating;
    }
}
