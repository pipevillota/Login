using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlMenu : MonoBehaviour
{
    public static ControlMenu instancia;
    [SerializeField] private TMP_Text puntos;
    private int Puntuacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(instancia == null)
        {
            instancia = this;
        }
    }
    public void SumarPuntuacion()
    {
        Puntuacion++;
        puntos.text = Puntuacion.ToString();
    }



}
