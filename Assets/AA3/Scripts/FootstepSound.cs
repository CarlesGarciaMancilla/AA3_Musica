using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;
using FMODUnity;

public class FootstepSound : MonoBehaviour
{
    /*public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;*/

    public FMODUnity.StudioEventEmitter footstepEmitter;

    private int materialNumber;

    // Start is called before the first frame update
    void PlayFootstepSFX()
    {
        footstepEmitter.SetParameter("SurfaceType", materialNumber);
        footstepEmitter.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "grass":
                materialNumber = 0;
                break;

            case "wood":
                materialNumber = 1;
                break;

            default:
                break;
        }
    }
}