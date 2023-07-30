using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declarando o Rigdbody2D
    private Rigidbody2D meuRB;
    [SerializeField] float velocidade = 5f;

    // Start is called before the first frame update
        void Start()
    {
        //Pegando o Rigdbody2D
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Pegando o input Horizontal
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 minhaVelocidade = new Vector2(horizontal, vertical);
        //Normalizando velocidade
        minhaVelocidade.Normalize();
        //Passando a minha velocidade para o meu RB
        meuRB.velocity = minhaVelocidade * velocidade;
    }
}
