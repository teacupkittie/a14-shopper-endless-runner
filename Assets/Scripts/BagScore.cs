using UnityEngine;
using UnityEngine.UI;

public class BagScore : MonoBehaviour {

	private int bagsInt = 0;
	public Text bagsText;
	
	// Update is called once per frame
	void Update () {
		bagsText.text = "Bags: " + bagsInt.ToString("0");
	}

	public void updateBags () {
		bagsInt += 1;
	}
}
