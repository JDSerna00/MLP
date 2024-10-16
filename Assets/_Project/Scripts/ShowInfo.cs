using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour
{
    public GameObject panelToShow;

    private void OnTriggerEnter(Collider other)
    {
        panelToShow.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        panelToShow.SetActive(false);
    }
}
