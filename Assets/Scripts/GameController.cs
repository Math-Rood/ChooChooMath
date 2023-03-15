using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    
    public void PauseResumeGame()
    {
        if (Time.timeScale == 1)
        {
            Debug.Log("Pausei");
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }else if (Time.timeScale == 0)
        {
            Debug.Log("Despausei");
            Time.timeScale = 1;
            pausePanel.SetActive(false); 
        }
        
        
    }
}
