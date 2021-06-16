using System.Collections.Generic;
using UnityEngine;

public static class InterfaceUtility 
{
    public static void GetInterfaces<T>(out List<T> resultList, GameObject objectToSearch) where T: class
    {
        MonoBehaviour[] list = objectToSearch.GetComponents<MonoBehaviour>();
        resultList = new List<T>();
        foreach (MonoBehaviour mb in list)
        {
            if (mb is T)
            {
                resultList.Add((T)((object)mb));
            }
        }
    }

    public static T GetInterface<T>(GameObject objectToSearch) where T: class
    {
        MonoBehaviour[] list = objectToSearch.GetComponents<MonoBehaviour>();
        foreach (MonoBehaviour mb in list)
        {
            if (mb is T)
            {
                return (T)((object)mb);
            }
        }
        return null;
    }
}
