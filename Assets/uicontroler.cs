using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControler : MonoBehaviour
{
    
    public void IntroducirTexto(string texto)
    {
        Debug.Log("Texto en cartel: " + texto);
    }

    
    public void AbrirCartel()
    {
        Debug.Log("Cartel abierto");
    }

    
    public void CerrarCartel()
    {
        Debug.Log("Cartel cerrado");
    }
}
