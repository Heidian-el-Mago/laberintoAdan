using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool gotKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gotKey = true;
            Destroy(gameObject);
        }
    }
}