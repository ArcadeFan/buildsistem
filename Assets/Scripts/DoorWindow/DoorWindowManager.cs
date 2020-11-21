using System.Collections.Generic;
using UnityEngine;

public class DoorWindowManager : MonoBehaviour
{
    private List<DoorWindow> _doorWindows = new List<DoorWindow>();

    public void AddDoorWindow(DoorWindow doorWindow)
    {
        if (!_doorWindows.Exists(x => x._itemId == doorWindow._itemId))
            return;

        _doorWindows.Add(doorWindow);
    }

    public void UpdateDoorWindow(DoorWindow doorWindow)
    {
        if (!_doorWindows.Exists(x => x._itemId == doorWindow._itemId))
            return;

        var newProperties = _doorWindows.Find(x => x._itemId == doorWindow._itemId);
        newProperties = doorWindow;
    }

    public void DeleteDoorWindow(int doorWindowId)
    {
        if (!_doorWindows.Exists(x => x._itemId == doorWindowId))
            return;

        _doorWindows.RemoveAt(doorWindowId);
    }
}
