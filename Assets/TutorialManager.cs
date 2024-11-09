using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private GameObject[] tutorialPanels; // Array de paneles del tutorial
    private int currentPanelIndex = 0;

    private void Awake()
    {
        if (tutorialPanels.Length > 0)
        {
            // Asegúrate de que solo el primer panel esté activo al inicio
            for (int i = 0; i < tutorialPanels.Length; i++)
            {
                tutorialPanels[i].SetActive(i == 0);
            }
        }
    }
    private void Update()
    {
        // Detecta cualquier clic del mouse
        if (Input.GetMouseButtonDown(0))
        {
            OnNextPanel();
        }
    }

    public void OnNextPanel()
    {
        if (currentPanelIndex < tutorialPanels.Length)
        {
            // Desactiva el panel actual
            tutorialPanels[currentPanelIndex].SetActive(false);

            currentPanelIndex++;

            if (currentPanelIndex < tutorialPanels.Length)
            {
                // Activa el siguiente panel
                tutorialPanels[currentPanelIndex].SetActive(true);
            }
            else
            {
                // Destruye el Tutorial Manager cuando se terminen los paneles
                Destroy(gameObject);
            }
        }
    }
}
