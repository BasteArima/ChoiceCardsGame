using UnityEngine;

[CreateAssetMenu(menuName = "Story/ChaptersDataContainer")]
public class ChaptersDataContainer : ScriptableObject
{
    public int currentChapter;
    public ChapterData[] scenes;
}
