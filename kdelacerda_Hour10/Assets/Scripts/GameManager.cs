using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GoalScript blue, green, red, orange, chaos;
    public float elapsedTime = 0;
    public bool isRunning = false;
    public bool isFinished = false;
    public FirstPersonController fpsController;

    void Start()
	{
		// Finds the First Person Controller script on the Player
		player=GameObject.FindWithTag("Player");
        fpsController = player.GetComponent<FirstPersonController>();
        fpsController.enabled = false;
        Time.timeScale = 0;
	}    

    void Update ()
    {
        // If all four goals are solved then the game is over
       isFinished = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
		if (isFinished) 
        {
            FinishedGame();
        }
        if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
    }
    void OnGUI()
        {
        if(!isRunning)
            {
                string message;

                if(isFinished)
                {
                    message = "Press Enter to Play Again";
                }
                else
                {
                    message = "Press Enter to Play";
                }

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/3, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
                if(isFinished)
                {
                    Restart(); 
                }
                else
                {
                    //start the game if the user clicks to play
                    StartGame ();
                }
			}
		}
		
		// If the player finished the game, show the final time
		if(isFinished)
		{
			GUI.Box(new Rect(Screen.width / 2 - 100, 210, 240, 40), "Game Over. Your Time Was " + ((int)elapsedTime).ToString());
		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 125, 40), "Your Time Is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
		}
       if(isFinished)
       {
           Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 15, 60, 40);
           GUI.Label (rect2, "Good Job!");
           isRunning = false;
         }
      }
      	void FinishedGame()
	{
		isRunning = false;
		//isFinished = true;
		fpsController.enabled = false;
        Time.timeScale = 0;
	}
    	//This resets to game back to the way it started
	void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;
        fpsController.enabled = true; 
        Time.timeScale = 1;
	}
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
