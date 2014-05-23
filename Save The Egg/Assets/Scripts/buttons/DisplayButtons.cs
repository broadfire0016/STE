using UnityEngine;
using System.Collections;

public class DisplayButtons : MonoBehaviour {

	public UIToolkit buttonsManager;
	private int level;
	// Use this for initialization

	void Start () {
		level = Main.getLevel();
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var homeButton = UIButton.create(buttonsManager,"home_normal.png","home_active.png",0,0);
		//homeButton.positionFromTopLeft( 0.718f, 0.253f );
		homeButton.positionFromCenter( 0.27f, -0.09f );
		homeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		homeButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		homeButton.setSize(homeButton.width / scaleFactor - 7.5f, homeButton.height / scaleFactor - 9.5f);

		if (level <= 10){
		var nextButton = UIButton.create(buttonsManager, "next_normal.png","next.png",0,0);
		//nextButton.positionFromTopLeft( 0.718f, 0.415f );
		nextButton.positionFromCenter( 0.27f, 0.09f );
		nextButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		nextButton.onTouchUpInside += sender => Application.LoadLevel("Level"+level);
		nextButton.setSize(nextButton.width / scaleFactor + 84f, nextButton.height / scaleFactor + 25.5f);
		}
	}
	


}
