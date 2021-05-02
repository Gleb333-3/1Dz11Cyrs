using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    [SerializeField]
    private Transform _Lig;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        _Lig.Rotate(Vector3.up * Time.deltaTime * 5);
    }
}