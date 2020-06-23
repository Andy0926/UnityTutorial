using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    // Start is called before the first frame update
    [SerializeField] State[] nextStates;
    //[SerializeField] string storyText;

    public string GetStateStory()
    {
        return storyText;
    }
    public State[] GetNextStates(){
        return nextStates;
    }
}
