using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField]
    Material Lava;

    [SerializeField]
    Material Wall;


    private void OnCollisionEnter (Collision col)
   {
      if (col.gameObject.tag == "Player")
      {
         gameObject.GetComponent<MeshRenderer>().material = Lava;
      }
   } 
}
