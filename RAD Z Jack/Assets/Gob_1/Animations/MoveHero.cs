using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            animator = GetComponent<Animator>();
        else
            print("Animator Component found");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isRunning", true);
        }
           

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -30*Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
       
        





    }
}
