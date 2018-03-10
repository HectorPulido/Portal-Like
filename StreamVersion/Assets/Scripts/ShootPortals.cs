using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPortals : MonoBehaviour
{
    public Transform portal1;
    public Transform portal2;
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
            ShootPortal(portal1);
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))
            ShootPortal(portal2);
    }

    void ShootPortal(Transform portal)
    {
        RaycastHit rh;
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(r, out rh))
        {
            portal.position = rh.point;
            portal.forward = rh.normal;
        }
    }
}
