using UnityEngine;

public class MetaDetection : MonoBehaviour
{

[SerializeField]
GameObject pantallaFinal;

private void OnTriggerEnter(Collider other)
{
   if (other.tag == "Player")
   {
      Debug.Log("El Jugador llegó a la meta");
   }
}
}