// Main Controller of the Game, it sets up the target score and Time Limit for each Level
// Author: Levi Joy Lim

using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	public static int minutes = 1;
	public static int seconds = 30;
	private static int score;
	private static int TargetScore;
	private static int level;
	private static int highScore = 0;


	void Start () {
		//PlayerPrefs.SetInt("High Score", 0);
		var Scores = gameObject.GetComponent<Score>();
		Level record = gameObject.GetComponent<Level>();

		switch (Application.loadedLevelName)
		{
		case "Level1":
				level = 1;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(15);
				Scores.setScore(score);
				break;
		case "Level2":
				level = 2;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(30);
				Scores.setScore(score);
				break;
		case "Level3":
				level = 3;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(45);
				Scores.setScore(score);
				break;
		case "Level4":
				level = 4;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(60);
				Scores.setScore(score);
				break;
		case "Level5":
				level = 5;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(75);
				Scores.setScore(score);
				break;
		case "Level6":
				level = 6;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(90);
				Scores.setScore(score);
				break;
		case "Level7":
				level = 7;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(105);
				Scores.setScore(score);
				break;
		case "Level8":
				level = 8;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(120);
				Scores.setScore(score);
				break;
		case "Level9":
				level = 9;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(135);
				Scores.setScore(score);
				break;
		case "Level10":
				level = 10;
				Timer.SetTimer(1,30);
				Scores.SetTargetScore(150);
				Scores.setScore(score);
				break;
		case "levelComplete":
				record.setScore(score);
				record.SetTargetScore(TargetScore);
				break;
		case "gameOver":
				record.setScore(score);
				record.SetTargetScore(TargetScore);
				break;
		}
		
	}

	void Update () {
		if (Application.loadedLevelName != "levelComplete" && Application.loadedLevelName != "gameOver"){
			var mins = Timer.GetMinutes();
			var secs = Timer.GetSeconds();
			var Scores = gameObject.GetComponent<Score>();
			BasketScript basketObject = GameObject.Find("basketBody").GetComponent<BasketScript>();
			score = basketObject.getScore();
			Scores.setScore(score);
			TargetScore = Scores.getTargetScore();

			if (mins == 0 && secs == 0){

				if (score > highScore){
					highScore = score;
					PlayerPrefs.SetInt("High Score", highScore);
					
				}
				if (score >= TargetScore){
					level++;
					Application.LoadLevel("levelComplete");
				}
				else{
					level = 1;
					Application.LoadLevel("gameOver");
				}
			}
		}
	}
	
	public static int getLevel(){
		return level;
	}

	public static int getHighScore(){
		highScore = PlayerPrefs.GetInt("High Score");
		return highScore;
	}


}
