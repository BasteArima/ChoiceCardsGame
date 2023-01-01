using UnityEngine;

[CreateAssetMenu(menuName = "Data/AppData")]
public class AppData : ScriptableObject
{
    public UserData userData;
    public SessionData sessionData;
    public ChaptersDataContainer chaptersDataContainer;
}
