using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    public Animator cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.F) && cube.GetBool("RotationBool") == false)
       {
            cube.SetBool("RotationBool", true); 
       }
       else if (Input.GetKeyDown(KeyCode.F) && cube.GetBool("RotationBool") == true)
       {
            cube.SetBool("RotationBool", false);
       }
    }
}