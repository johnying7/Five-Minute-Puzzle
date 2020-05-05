using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    public int coinsRequired = 0;
    public bool requirementsSatisfied = false;
    private Transform doorHinge;
    public Text requiredDoorText;

    // Start is called before the first frame update
    void Start()
    {
        if (coinsRequired <= 0) {
            Debug.LogError("Coins required must be greater than zero.");
        }
        GameObject.FindWithTag("CoinManager").GetComponent<CoinManager>().addDoorController(this);
        doorHinge = this.transform.GetChild(0);
        string requiredAmountSign = "Required: " + coinsRequired.ToString();
        requiredDoorText.text = requiredAmountSign;
    }

    /// <summary>
    /// On triggering with the player, it calls the open door method.
    /// </summary>
    /// <param name="collision">the collider object to check against</param>
    void OnTriggerEnter(Collider collider)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collider.gameObject.tag == "Player" && requirementsSatisfied)
        {
            openDoor();
        }
    }

    /// <summary>
    /// Checks if the required coins matches the current coins, and changes the state if true.
    /// </summary>
    /// <param name="currentCoins">current total collected coins</param>
    public void setRequirementsSatisfied(int currentCoins) {
        if (currentCoins == coinsRequired) {
            requirementsSatisfied = true;
        }
    }

    /// <summary>
    /// Opens the associated door.
    /// </summary>
    public void openDoor() {
        doorHinge.GetComponent<Animator>().SetBool("isOpen", true);
    }
}
