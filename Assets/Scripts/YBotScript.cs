using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBotScript : MonoBehaviour
{
    Animator animator;
    public float moveSpeed = 1.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        bool runN = Input.GetKey("w");
        bool runS = Input.GetKey("s");
        bool runE = Input.GetKey("d");
        bool runW = Input.GetKey("a");

        if (runN)
        {
            // Cambiar la animación a correr
            animator.SetInteger("State", 1);

            // Mover solo hacia el norte
            Vector3 moveDirection = new Vector3(0, 0, 1);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if(runS)
        {
            
            animator.SetInteger("State", 1);
            Vector3 moveDirection = new Vector3(0, 0, 1);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        else if(runE){
            animator.SetInteger("State", 1);
            Vector3 moveDirection = new Vector3(0, 0, 1);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if(runW){
            animator.SetInteger("State", 1);
            Vector3 moveDirection = new Vector3(0, 0, 1);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 270, 0);

        }
        else
        {
            // Cambiar la animación a idle
            animator.SetInteger("State", 0);
        }
    }
}
