using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to our PlayerMovement script
	private BagScore bagScore;

	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".

	void Start()
	{
		bagScore = GameObject.Find("Bags").GetComponent<BagScore>();
	}
	
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}

		// If it is a shopping bag, collect it!
		if(collisionInfo.gameObject.tag == "Bag")
		{
			Destroy(collisionInfo.gameObject); // Make that bag disappear
			bagScore.updateBags();
		}
	}

}
