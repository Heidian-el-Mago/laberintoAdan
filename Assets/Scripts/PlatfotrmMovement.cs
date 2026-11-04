using UnityEngine;

public class PlatfotrmMovement : MonoBehaviour
{
public float pausa = 1f;
private float esperando = 0f;
public float tiempo = 2f;
private float contador = 0f;
private int sentido = -1;

void Update()
{
    if (esperando > 0f)
    {
        esperando -= Time.deltaTime;
        return; // no se mueve mientras espera
    }

    transform.Translate(sentido * 1f * Time.deltaTime,0f,0f);
    contador += Time.deltaTime;

    if (contador >= tiempo)
    {
        sentido = -sentido;
        contador = 0f;
        esperando = pausa;
    }
}
}
