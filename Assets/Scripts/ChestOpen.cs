using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public Animator chest;
    // Start is called before the first frame update
    void Start()
    {
        chest = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            chest.SetTrigger("ChestOpen");
        }
    }
}
