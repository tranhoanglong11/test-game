using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Animator animator;
    float m = 0.0f;
    int verHash;
    int horHash;
    float a = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        verHash = Animator.StringToHash("vertical");
        horHash = Animator.StringToHash("horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        m += Time.deltaTime * a;
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        this.animator.SetFloat(verHash, vertical);
        this.animator.SetFloat(horHash, horizontal);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.animator.SetFloat("speed", m);
        }
        else
        {
            m = 0;
            this.animator.SetFloat("speed", m);

        }
    }
}
