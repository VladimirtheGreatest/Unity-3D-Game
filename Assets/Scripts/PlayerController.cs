using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //  private Animator anim;
    private NavMeshAgent agent;
    public EventVector3 OnClickEnvironment;
    public Texture2D doorway; // cursor for doorways
    public LayerMask clickableLayer;
    public RaycastHit hit;
    void Awake()
    {
        // anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }
}

