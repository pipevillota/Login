using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPajaro : MonoBehaviour
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
}
