using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class PrisonGame : MonoBehaviour
{
    // configuration parameters
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    // state variables
    State state;

    // Use this for initialization
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        // todo challenge to support more keys
        textComponent.text = state.GetStateStory();
    }
}