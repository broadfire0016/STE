using UnityEngine;
using System.Collections;

public class ScaleFactor : MonoBehaviour {
	/// <summary>
	/// Gets the scale factor that is native to the device versus the Prime31's UI library scale factor.
	/// </summary>
	/// <returns>
	/// The scale factor. All graphic assets should be resized by dividing it's width/height with this value.
	/// </returns>
	private static float scaleFactor;

	public static float GetScaleFactor() {
		if (scaleFactor == 0) {
			int normalWidth = 384;
			int normalHeight = 512;
			
			var tempWidth = normalWidth * UI.scaleFactor;
			var tempHeight = normalHeight * UI.scaleFactor;
			float factorX = tempWidth / (float)Screen.width;
			float factorY = tempHeight / (float)Screen.height;
			
			scaleFactor = Mathf.Max(factorX, factorY);
		} 
		return scaleFactor;
	}
}
