using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResourceManager : Singleton<ObjectResourceManager>
{
    [SerializeField] private List<Sprite> objects;

    public Sprite GetObject(int id)
    {
        if (id >= objects.Count)
        {
            Debug.Assert(true, "id great objects size: " + objects.Count);
        }

        return objects[id];
    }

    public Sprite GetRandomObject()
    {
        return GetObject(Random.Range(0, objects.Count));
    }
}
