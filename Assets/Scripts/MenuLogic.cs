using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    public GameObject InGamePanel;
    public GameObject SettingsPanel;



    public void StartGame()
    {
        InGamePanel.SetActive(true);
    }

    public void StopGame()
    {
        InGamePanel.SetActive(false);
    }

    public void OpenSettings()
    {
        SettingsPanel.SetActive(true);
    }
    
    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
    }

}
