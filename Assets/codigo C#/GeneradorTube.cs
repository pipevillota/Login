using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTube : MonoBehaviour
{
    [SerializeField] private GameObject tuberias;
    private float alturaMinima = -1f;
    private float alturaMaxima = 3f;
    private float intervalo = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(methodName: "CreadorTuberias", time:0, repeatRate: intervalo);
    }

    private void CreadorTuberias()
    {
        Vector2 posicionInicial;
        posicionInicial.x = transform.position.x;
        posicionInicial.y = Random.Range(alturaMinima, alturaMaxima);
        Instantiate(tuberias, (Vector3)posicionInicial, Quaternion.identity);
    }
}