using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptuletzuAstaPoateMerge : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Cos;
    public Text Text;
    public GameObject controller1;
    public GameObject controller2;
    
    
    private float ballDistance = 2f;
    private bool holdingBall = false;
    private bool gotTheBall = false;

    private int score = 0;
    void Start()
    {
        Text.text = "";
    }

    void Update()
    {
        print(Vector3.Distance(Ball.transform.position, Cos.transform.position));
        if(Vector3.Distance(Ball.transform.position, Cos.transform.position) < 0.3f) {
            Text.text = "Ai inscris";
        } 

        if(Vector3.Distance(Ball.transform.position, controller1.transform.position) < 0.15f || 
           Vector3.Distance(Ball.transform.position, controller2.transform.position) < 0.15f) 
        {
            Ball.transform.position -= new Vector3(0.16f, 0f, 0f);
        }


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
