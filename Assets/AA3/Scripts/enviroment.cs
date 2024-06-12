using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class EnvironmentChange : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter snapshotEmitter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Indoor")
        {
            snapshotEmitter.Play();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Indoor")
        {
            snapshotEmitter.Stop();
        }
    }
}
