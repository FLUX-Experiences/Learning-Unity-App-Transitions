using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : MonoBehaviour {

    public string Title;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public string Transition_In_Trigger;
    public string Transition_Out_Trigger;
    public void Transition_IN()
    {
        _animator.SetTrigger(Transition_In_Trigger);
    }
    public void Transition_OUT()
    {
        _animator.SetTrigger(Transition_Out_Trigger);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
