using UnityEngine;

public class ChangeCameraOnTouch : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
       
            ChangeCamera();
        
    }

    void ChangeCamera()
    {
        gameOverPanel.SetActive(true);
    }
}
