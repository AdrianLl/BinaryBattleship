using UnityEngine;
using System.Collections;

public class PanelBehaviour : MonoBehaviour
{
    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }
}
