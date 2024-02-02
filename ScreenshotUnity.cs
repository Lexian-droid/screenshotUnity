/*

    Written by ChatGPT
    Adapted by LexianDEV
    Available on Github at https://gist.github.com/Lexian-droid/eab4b3c7b9c55c7bf9b6f84613518883

*/

using UnityEngine;

public class ScreenshotUnity : MonoBehaviour
{
    [Header("Keybinds")]
    public KeyCode keyCode = KeyCode.P;

    void Update()
    {
        // Example: Capture screenshot when a key is pressed (change as needed)
        if (Input.GetKeyDown(keyCode))
        {
            CaptureScreenshot();
        }
    }

    public void CaptureScreenshot()
    {
        // Hide the cursor
        Cursor.visible = false;

        // Capture screenshot
        string screenshotName = "Assets/Screenshots/Screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        ScreenCapture.CaptureScreenshot(screenshotName);

        // Show cursor after a short delay (optional)
        StartCoroutine(ShowCursorAfterDelay());
    }

    System.Collections.IEnumerator ShowCursorAfterDelay()
    {
        // Wait for a short delay to allow time for the screenshot to be captured
        yield return new WaitForSeconds(0.5f);

        // Show cursor
        Cursor.visible = true;
    }
}