using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    public int currentCoinsCollected = 0;
    public int winCount = 0;
    public string endGameSceneName = "EndGameScene";
    List<DoorController> doors = new List<DoorController>();

    // Start is called before the first frame update
    void Start()
    {
        if (winCount <= 0) {
            Debug.LogError("Coin Manager win count must be greater than zero.");;
        }
    }

    /// <summary>
    /// Increments the coin count and applies the change to the associated doors with
    /// the new update.
    /// </summary>
    public void incrementCoinsCollected() {
        currentCoinsCollected++;
        if (currentCoinsCollected >= winCount) {
            SceneManager.LoadScene(endGameSceneName);
        }
        for (int i = 0; i < doors.Count; i++) {
            doors[i].setRequirementsSatisfied(currentCoinsCollected);
        }
    }

    public void addDoorController(DoorController door) {
        doors.Add(door);
    }
}
