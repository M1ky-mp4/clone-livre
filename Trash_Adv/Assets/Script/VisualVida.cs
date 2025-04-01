using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VisualVida : MonoBehaviour
{
    public TMP_Text meuTexto;

    void Update()
    {
        float vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Personagens>().vida;

        meuTexto.text = "VIDA: " + vida.ToString();
    }
}

