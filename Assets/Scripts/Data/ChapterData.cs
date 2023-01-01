using UnityEngine;

[CreateAssetMenu(menuName = "Story/ChapterData")]
public class ChapterData : ScriptableObject
{
    public int currentScene;
    public SceneData[] scenes;
}