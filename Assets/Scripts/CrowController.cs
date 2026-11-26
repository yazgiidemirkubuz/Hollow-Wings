using UnityEngine;
using UnityEngine.InputSystem;

public class CrowController : MonoBehaviour
{

    public float jumpPower = 5; 
    private Rigidbody2D rb; 
    public bool isGameover = false; 
    public GameObject gameOverText; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = (Vector2.up * jumpPower);
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision " + other.name);
        Time.timeScale = 0;
        isGameover = true; 
        gameOverText.SetActive(true); 
    }
}
