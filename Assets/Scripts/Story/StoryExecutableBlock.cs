using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StoryExecutableBlock : MonoBehaviour
{
    public abstract bool IsCompleted { get; protected set; }
    public abstract void StartExecute();
    public virtual void Reset()
    {
        IsCompleted = false;
    }
}
