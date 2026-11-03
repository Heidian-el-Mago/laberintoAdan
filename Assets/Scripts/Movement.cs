using UnityEngine;

public class Movement : MonoBehaviour
{
    public float distance = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(-13.5f,0.64f,-16.56f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(0.1f,0f,0f);
    }
        if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(-0.1f,0f,0f);
    }
       if (Input.GetKey(KeyCode.W))
    {
        transform.Translate(0f,0f,0.1f);
    }
        if (Input.GetKey(KeyCode.S))
    {
        transform.Translate(0f,0f,-0.1f);
    }
    }
}
