using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class email : MonoBehaviour
{
    public void mailto(string mail)
    {
        Application.OpenURL("mailto:" + mail);
    }

}
