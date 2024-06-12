using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using FMODUnity;

public class MusicChange : MonoBehaviour
{

    //public AudioMixerSnapshot baseSnapshot;
    //public AudioMixerSnapshot calmSnapshot;
    //public AudioMixerSnapshot combatSnapshot;

    //public float transitionTime = 2.0f;
    //public float transitionTimeCombat = 0.5f;

    public FMODUnity.StudioEventEmitter calmSnapshot;
    public FMODUnity.StudioEventEmitter combatSnapshot;
    public FMODUnity.StudioEventEmitter baseSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tensionArea")
        {
            
            baseSnapshot.Stop();
            calmSnapshot.Play();
            combatSnapshot.Stop();
        }
        else if (other.gameObject.tag == "Indoor") 
        {
            combatSnapshot.Play();
            calmSnapshot.Stop();
            baseSnapshot.Stop();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "tensionArea")
        {
            baseSnapshot.Play();
            calmSnapshot.Stop();
        }
        else if (other.gameObject.tag == "Indoor")
        {
            combatSnapshot.Stop();
            calmSnapshot.Play();
        }
    }
}
