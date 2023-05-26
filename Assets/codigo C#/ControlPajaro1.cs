using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPajaro1 : MonoBehaviour
{
    [SerializeField] private float fuerzaDeSalto;
    private Rigidbody2D rbPajaro;
    // Start is called before the first frame update
    void Start()
    {
        rbPajaro = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbPajaro.velocity = Vector2.up * fuerzaDeSalto;
        }

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Puntuacion")
        {
            ControlMenu.instancia.SumarPuntuacion();
        }
    }

}
