using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo01Controller : MonoBehaviour
{
    //Pegar o Rigdbody
    private Rigidbody2D meuRB;
    [SerializeField] private float velocidade = -3f;

    // Start is called before the first frame update
    void Start()
    {
        //Peganfo meu RB
        meuRB = GetComponent<Rigidbody2D>();
        //Dando a velocidade para o RB
        meuRB.velocity = new Vector2(0f, velocidade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
