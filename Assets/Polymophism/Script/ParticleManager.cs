using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void Selected()
    {
        particle.Play();
    }
}
