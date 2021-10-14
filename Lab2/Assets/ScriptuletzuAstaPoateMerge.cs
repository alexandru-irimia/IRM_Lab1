using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptuletzuAstaPoateMerge : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Cos;
    public Text Text;
    
    
    private float ballDistance = 2f;
    private float ballThrowingForce = 5f;
    private bool holdingBall = false;

    private int score = 0;
    void Start()
    {
       // var ceva = actionAsset.FindActionMap("XRI LeftHand").FindAction("gripPressed");
        //Ball.GetComponent<Rigidbody> ().useGravity = false;
        Text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //Text.text = $"Score: {score}";
        //Text.text = "Ai inscris";
        print(Vector3.Distance(Ball.transform.position, Cos.transform.position));
        if(Vector3.Distance(Ball.transform.position, Cos.transform.position) < 0.3f) {
            Text.text = "Ai inscris";
        } 
        // if ( Input.GetKeyDown(KeyCode.G) == true ) {
        //     ;
        // }
        Ball.GetComponent<Rigidbody> ().AddForce(new Vector3(0.0f, 0.0f, 0.0f));
        if (holdingBall) {
            Ball.transform.position = Cos.transform.position + Cos.transform.forward * ballDistance;
            
            if (Input.GetMouseButtonDown(0)) {
                holdingBall = false;
                Ball.GetComponent<Rigidbody> ().useGravity = true;
                
            }
        }
    }
}
