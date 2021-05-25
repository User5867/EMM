using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSkript : MonoBehaviour
{
    [SerializeField] GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyUp(KeyCode.Escape))
        { if (!menu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
            menu.SetActive(!menu.activeSelf);
        }
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Return()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
    }
}
