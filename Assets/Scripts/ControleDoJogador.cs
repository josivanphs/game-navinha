using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D oRigidbody2d;

    public GameObject laserDoJogador;
    
    public Transform localDoDisparoUnico;

    public float velocidadeDaNave;

    public bool temLsaerDuplo;

    private Vector2 teclasApertadas;


    // Start is called before the first frame update
    void Start()
    {
        temLsaerDuplo = false;

    }

    // Update is called once per frame
    void Update()
    {
        MovimentarJogador();
        AtirarLaser();
    }

    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        oRigidbody2d.velocity = teclasApertadas.normalized * velocidadeDaNave;
    }

    private void AtirarLaser()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (temLsaerDuplo == false)
            {
                Instantiate(laserDoJogador, localDoDisparoUnico.position, localDoDisparoUnico.rotation);
            }
            
        }
    }

}

