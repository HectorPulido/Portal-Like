using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Portal : MonoBehaviour
{
    public Portal pair;
    public Transform portalGate;

    void OnTriggerEnter(Collider col)
    {
        col.transform.position = pair.portalGate.position;
        if (col.CompareTag("Player"))
        {
            var FPC = col.GetComponent<RigidbodyFirstPersonController>();
            FPC.mouseLook.m_CharacterTargetRot = Quaternion.Euler(col.transform.eulerAngles.x, pair.portalGate.eulerAngles.y , col.transform.eulerAngles.z);
        }
        else
        {
            col.transform.rotation = pair.portalGate.rotation;
        }
    }
}
