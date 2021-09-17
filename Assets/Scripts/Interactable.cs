using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public float interactRadius = 2f;
    protected bool isFocus = false;
    protected GameObject subject;

    private bool hasInteracted = false;

    public abstract void Interact(GameObject subject);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public void OnFocused(GameObject NewSubject)
    {

    }

    public void OnDefocused()
    {

    }
}
