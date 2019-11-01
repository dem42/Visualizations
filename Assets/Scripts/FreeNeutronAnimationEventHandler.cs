using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeNeutronAnimationEventHandler : MonoBehaviour
{
    
    void HideNeutronWhenAbsorbed() {
        Debug.Log("Animation event callback received");
        //gameObject.SetActive(false);
    }
}
