using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int currentCoinsCollected = 0;
    List<DoorController> doors = new List<DoorController>();

    /// <summary>
    /// Increments the coin count and applies the change to the associated doors with
    /// the new update.
    /// </summary>
    public void incrementCoinsCollected() {
        currentCoinsCollected++;
        for (int i = 0; i < doors.Count; i++) {
            doors[i].setRequirementsSatisfied(currentCoinsCollected);
        }
    }
}
