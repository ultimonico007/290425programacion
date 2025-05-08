using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static tienda;

public class controler : MonoBehaviour
{
    void Start()
    {
        Tienda espada = new Tienda{ nombre ="espada de hierro",precio=1.5f};
        Tienda escudo = new Tienda{ nombre ="escudo de madera",precio=0.5f};
        Tienda pistola = new Tienda{ nombre ="pistola:pew-pew",precio=9999f};

        Debug.Log($"producto:{espada.nombre},precio:${espada.precio}");
        Debug.Log($"producto:{escudo.nombre},precio:${escudo.precio}");
        Debug.Log($"producto:{pistola.nombre},precio:${pistola.precio}");
    }
}

