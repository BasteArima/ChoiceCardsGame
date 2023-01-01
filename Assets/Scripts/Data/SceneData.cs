using UnityEngine;

[CreateAssetMenu(menuName = "Story/SceneData")]
public class SceneData : ScriptableObject
{
    public Sprite background;
    public string storyText;
    public CardData[] cards;
    public StoryExecutableBlock[] startEvents;
    public StoryExecutableBlock[] endEvents;
}

[System.Serializable]
public class CardData
{
    public Sprite contentSprite;
    public string text;
    public string choicedText;
    public SceneData nextScene;
    public StoryExecutableBlock[] choiseEvents;
}
