using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public Rigidbody grenatePrefab;
    public Transform grenateSourceTransform;
    public float force = 10;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var grenate = Instantiate(grenatePrefab);
            grenate.transform.position = grenateSourceTransform.position;
            grenate.GetComponent<Rigidbody>().AddForce(grenateSourceTransform.forward * force);
        }
    }
}
