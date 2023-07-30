using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declarando o Rigdbody2D
    private Rigidbody2D meuRB;

    // Start is called before the first frame update
        void Start()
    {
        //Pegando o Rigdbody2D
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
