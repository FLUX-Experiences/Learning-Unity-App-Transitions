using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOrganizer : MonoBehaviour {

    private List<MenuScreen> Screens;
    private MenuScreen _currentScreen;

    private void Awake()
    {
        Screens = new List<MenuScreen>();
        for (int i=0; i < transform.childCount; i++)
        {
            Screens.Add(transform.GetChild(i).GetComponent<MenuScreen>());
        }

    }

    // Use this for initialization
    void Start()
    {
        SwitchScreen(Screens[0]);

    }
    
    public void SwitchScreen(MenuScreen newScreen)
    {
        if (newScreen != _currentScreen)
        {
            newScreen.Transition_IN();
            if (_currentScreen != null) _currentScreen.Transition_OUT();

            _currentScreen = newScreen;
        }
    }

    
	
	// Update is called once per frame
	void Update () {
		
	}
}
