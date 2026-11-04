using UnityEngine;

public class LavaTouch : MonoBehaviour
{
    public Transform Spawn;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.position = Spawn.position;
        }
    }
}
