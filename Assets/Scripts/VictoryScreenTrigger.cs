using UnityEngine;

public class VictoryScreenTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject MessageVictory;

    private void Start()
    {
        MessageVictory.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Llegaste a la meta");
            MessageVictory.SetActive(true);
        }
    }
}
