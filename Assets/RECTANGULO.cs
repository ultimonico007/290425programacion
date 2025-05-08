using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    
    public UIControler canvasManager;
    private Animator anim;

    private void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        CUBO1 cubo = collision.GetComponent<CUBO1>();
        if (cubo != null)
        {
            
            string saludo = "Hola " + cubo.Nombre + ", bienvenido al área del Rectángulo.";
            canvasManager.IntroducirTexto(saludo);
            if (anim != null)
            {
                anim.Play("SaludoRectangulo");
            }
            canvasManager.AbrirCartel();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        canvasManager.CerrarCartel();
    }
}