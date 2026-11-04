using UnityEngine;

public class Puerta : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player") && Key.gotKey) 
        {
            Destroy(gameObject);   // la puerta desaparece
        }
    }
}