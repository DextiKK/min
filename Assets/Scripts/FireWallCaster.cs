using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWallCaster : MonoBehaviour
{
    public FireWall firewallPrefab;
    public Transform firewallSourceTransform;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(firewallPrefab, firewallSourceTransform.position, firewallSourceTransform.rotation);
        }
    }
}
