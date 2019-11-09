using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleusAnimationEvntHandler : MonoBehaviour
{
    public ParticleSystem boomParticleSystem;

    void PlayOnCollision(int ok) {
        Debug.Log($"Collision just happened {ok}");
    }

    void PlayParticleBoom() {
        Debug.Log("Boom");
        boomParticleSystem.Play();
    }
}
