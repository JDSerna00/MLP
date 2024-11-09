using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Pieces : MonoBehaviour, IClickable
{
    [SerializeField] Transform targetPos;
    public GameObject piecePanelInfo;
    public float speed = 2.0f;
    Vector3 startPos;
    private bool isMovingToTarget = true;
    private bool travelling = false;

    private void Start()
    {
        startPos = transform.position;  
    }

    private void Update()
    {
        if (piecePanelInfo != null)
        {
            if (Vector3.Distance(transform.position, targetPos.position) < 0.1f)
            {
                piecePanelInfo.SetActive(true);
            }
            else { piecePanelInfo.SetActive(false); } 
        }
       
        if (travelling) 
        {
            var step = Time.deltaTime * speed;
            Vector3 target =isMovingToTarget?targetPos.position : startPos;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
            if (Vector3.Distance(transform.position, target) < 0.01f)
            {
                travelling = false;
            }
        }
    }
    public void OnClick()
    {
        Debug.Log($"Touched this piece{gameObject}");
        travelling = true;
        isMovingToTarget = !isMovingToTarget;
    }
    // Start is called before the first frame update

}
