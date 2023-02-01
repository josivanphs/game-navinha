using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    public Slider barraDeVidaDoJogador;

    public int vidaMaximaDojogador;

    public int vidaAtualDoJogador;

    public bool temEscudo;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDojogador;
        barraDeVidaDoJogador.maxValue = vidaMaximaDojogador;
        barraDeVidaDoJogador.value = vidaAtualDoJogador;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MachucarJogador(int danoParareceber)
    {
        if(temEscudo == false)
        {
            vidaAtualDoJogador -= danoParareceber;
            barraDeVidaDoJogador.value = vidaAtualDoJogador;
            if(vidaAtualDoJogador <= 0)
            {
                Debug.Log("Game Over");
            }


        }
    }

}

