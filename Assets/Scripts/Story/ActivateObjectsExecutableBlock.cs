using UnityEngine;

public class ActivateObjectsExecutableBlock : StoryExecutableBlock
{
    [SerializeField] private GameObject[] _gameObjects;

    public override bool IsCompleted { get; protected set; }

    public override void StartExecute()
    {
        foreach (var gameObject in _gameObjects)
            gameObject.SetActive(true);
        IsCompleted = true;
    }
}