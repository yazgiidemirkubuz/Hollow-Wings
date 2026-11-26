using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    private CrowController crow; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        crow = GetComponent<CrowController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame && crow.isGameover) 
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

        }
    }
}
