using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField]
    Material Lava;

    [SerializeField]
    Material Wall;

    bool isColliding = false;
    float afterCollideTime = 5f;

    private void Update()
    {
      if (isColliding == true)
      {
         afterCollideTime = afterCollideTime - Time.deltaTime;
         if (afterCollideTime < 0.0f)
         {
               gameObject.GetComponent<MeshRenderer>().material = Wall;
               isColliding = false;
               afterCollideTime = 5f;
           
         }
      }
    }

    private void OnCollisionEnter (Collision col)
    {
      if (col.gameObject.tag == "Player")
      {
         gameObject.GetComponent<MeshRenderer>().material = Lava;
         isColliding = true;
      }
    } 
}
