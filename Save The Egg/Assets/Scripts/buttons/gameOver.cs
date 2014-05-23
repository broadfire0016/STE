using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {
		
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var menuButton = UIButton.create(buttonsManager, "menu_normal.png","menu.png",0,0);
		menuButton.positionFromCenter( 0.27f, -0.09f );
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		menuButton.setSize(menuButton.width/ scaleFactor , menuButton.height / scaleFactor);
		
		
		//retry
		var retryButton = UIButton.create(buttonsManager,"retry_normal.png","retry.png",0,0);
		retryButton.positionFromCenter( 0.27f, 0.09f );
		retryButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		retryButton.onTouchUpInside += sender => Application.LoadLevel("Level1");
		retryButton.setSize(retryButton.width/ scaleFactor , retryButton.height / scaleFactor);
	}
}
