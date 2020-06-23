using System;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    State state;

    void Start()
    {
        state=StartingState;
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
    }
} 
