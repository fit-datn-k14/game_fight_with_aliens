using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public Button[] levelButtons;

    public int levelReached = 1;

    private void Start()
    {
        if(CompleteLevel.gameIsPlayed) levelReached = PlayerPrefs.GetInt("levelReached", 1);
        Debug.Log("opening level: " + levelReached);
        for(int i=0; i< levelButtons.Length; i++)
        {   
            if(i + 1 > levelReached)
                levelButtons[i].interactable = false;
        }
    }
    public void Select(string levelName)
    {
        fader.FadeTo(levelName);
    }
}
