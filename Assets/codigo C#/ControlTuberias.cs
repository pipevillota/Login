using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTuberias : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;
    private float limiteIzquierda = -3.5f;
    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.left * velocidad * Time.deltaTime;
        if(this.transform.position.x < limiteIzquierda)
        {
            Destroy(this.gameObject);
        }
    }
}
