using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour
{
    [SerializeField] private Text storyTextComponent;
    [SerializeField] private State startingState;

    State state;

    void Start()
    {
        state = startingState;
        storyTextComponent.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (nextState[1] != null)
            {
                state = nextState[1];
            }
        }
        storyTextComponent.text = state.GetStateStory();
    }
}
