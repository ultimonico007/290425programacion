using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public uicontroler canvasManager;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cubo cubo = collision.GetComponent<cubo>();
        if (cubo != null)
        {
            if (cubo.Nombre == "Cubito")
            {
                cubo.Nombre = "Circulo";
                string saludo = "tu nombre es circulo";
                canvasManager.IntroducirTexto(saludo);
                anim.Play("Saludo1");
                canvasManager.AbrirCartel();
            }
            else
            {
                string saludo = "Me gusta tu nombre";
                canvasManager.IntroducirTexto(saludo);
                anim.Play("Saludo2");
                canvasManager.AbrirCartel();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canvasManager.CerrarCartel();
    }
}
