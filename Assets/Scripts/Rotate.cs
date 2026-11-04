using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform Spawn;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0.1f,0f);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.position = Spawn.position;
        }
    }
}
