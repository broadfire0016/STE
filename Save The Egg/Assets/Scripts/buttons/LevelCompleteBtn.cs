//Buttons in level Complete Scene
//Author: Levi

using UnityEngine;
using System.Collections;

public class LevelCompleteBtn : MonoBehaviour {
	private int level;
	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {

		level = Main.getLevel();
		var scaleFactor = ScaleFactor.GetScaleFactor ();

		var menuButton = UIButton.create(buttonsManager, "menu_normal.png","menu.png",0,0);
		menuButton.positionFromCenter( 0.29f, -0.12f );
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");

		if (level <= 10){
			var nextButton = UIButton.create(buttonsManager, "next_normal.png","next.png",0,0);
			nextButton.positionFromCenter( 0.29f, 0.12f );
			nextButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
			nextButton.onTouchUpInside += sender => Application.LoadLevel("Level"+level);
		
			


#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { //iphone4
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		}
		#endif

		#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) {
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		}
		
		if (Screen.width == 640 && Screen.height == 1136){
			menuButton.positionFromBottomLeft( 0.17f, 0.3f );
			menuButton.setSize(menuButton.width/ scaleFactor + 27, menuButton.height / scaleFactor + 20);
			nextButton.positionFromBottomLeft( 0.15f, 0.50f );
			nextButton.setSize(nextButton.width/ scaleFactor + 10, nextButton.height / scaleFactor + 15);
		
		#endif
	}
	}
}

}