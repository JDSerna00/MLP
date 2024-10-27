using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowInfo : MonoBehaviour, IClickable
{
    public GameObject panelToShow;
    bool showingPanel;

    public void OnClick()
    {
        showingPanel = !showingPanel;
    }

    private void Update()
    {
        if (showingPanel)
        {
            panelToShow.SetActive(false);
        }
        else
        {
            panelToShow.SetActive(true);
        }
    }
}
