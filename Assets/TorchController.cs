using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject torch;
    public float rotateSpeed = 10;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        /* var angH = Input.GetAxis("RightH") * 60;
         var angV = Input.GetAxis("RightV") * 45;
         transform.localEulerAngles = new Vector2(angV, angH);*/

        if (Input.GetAxis("RightV") != 0)
        {

            // float myAngle = Mathf.Atan2(Input.GetAxis("RightH"), Input.GetAxis("RightV")) / Mathf.Rad2Deg;
            // float bodyRotation = myAngle + torch.transform.eulerAngles.z;

            // transform.localEulerAngles = new Vector3(0, 0, bodyRotation);

            // var maxAngV = Input.GetAxis("RightV") * -85;
            //transform.localEulerAngles = new Vector3(0, 0, maxAngV);


            transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(Input.GetAxis("RightV"), Input.GetAxis("RightH")) * 180 / Mathf.PI);

        }

        if (Input.GetAxis("RightV") == 0)
        {
            transform.localEulerAngles = new Vector3(0, 0, 4.79f);
        }

    }
}
