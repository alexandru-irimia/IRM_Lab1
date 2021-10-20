using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscare : MonoBehaviour
{
    public GameObject hand;
    public GameObject controller;
    void Start()
    {
        controller.SetActive(false);
        // controller.transform.position += new Vector3(-0.15f, -0.15f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        hand.transform.position = controller.transform.position + new Vector3(0f, 0f, 0f);
        // hand.transform.rotation = controller.transform.rotation.eulerAngles;
        hand.transform.rotation = Quaternion.Euler(
            controller.transform.rotation.eulerAngles.x + 270f, 
            controller.transform.rotation.eulerAngles.y + 180f, 
            controller.transform.rotation.eulerAngles.z + 0f
            );
    }
}
