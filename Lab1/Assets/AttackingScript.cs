using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator1, animator2;
    public GameObject cactusObject1, cactusObject2;
    GameObject imageTarget1,  imageTarget2 ;
    bool isAttacking = false; // acelasi nume

    void Start()
    {
        animator1 = cactusObject1.GetComponent<Animator>();
        animator2 = cactusObject2.GetComponent<Animator>();

        imageTarget1 = cactusObject1.transform.root.gameObject;
        imageTarget2 = cactusObject2.transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        isAttacking = true;

        animator1.SetBool("isAttacking", true);
        animator2.SetBool("isAttacking", true);

        if(Vector3.Distance(imageTarget1.transform.position, imageTarget2.transform.position) < 0.35f) 
        {
            animator1.SetBool("isAttacking", true);
            animator2.SetBool("isAttacking", true);
            print("atack");
        }
        else
        {
            print("stai");
            animator1.SetBool("isAttacking", false);
            animator2.SetBool("isAttacking", false);
        }
    }
}
