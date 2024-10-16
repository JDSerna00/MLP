using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSwapper : MonoBehaviour
{
    public GameObject ModelShowed;
    public GameObject[] ModelsHideed;

    public void OnTriggerEnter(Collider other)
    {
        ModelShowed.SetActive(true);
        for (int i = 0; i < ModelsHideed.Length; i++)
        {
            ModelsHideed[i].SetActive(false);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        ModelShowed.SetActive(false);
    }
}
