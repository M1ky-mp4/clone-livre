using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisualCoracao : MonoBehaviour
{

    public Image FundoImagem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Personagens>().vida;

        int minhaVida = GameObject.FindGameObjectWithTag("Player").GetComponent<Personagens>().vida + 135;

        FundoImagem.rectTransform.sizeDelta = new Vector2(minhaVida, 100);


    }
}
