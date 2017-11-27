using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsContoller : MonoBehaviour {

	public void LoadNewLevel(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel)
    }
}
