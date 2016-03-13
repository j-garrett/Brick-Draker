using UnityEngine;
using System.Collections;

public class Startup : MonoBehaviour {

   public GameObject brickPrefab;

	// Use this for initialization
	void Start () {
	    setupBricks();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void setupBricks() {
        Renderer renderer = brickPrefab.GetComponent<Renderer>();
        float offsetX = renderer.bounds.extents.x * 2.1f;
        float offsetY = renderer.bounds.extents.y * 2.1f;
        
        int cols = Screen.width / (int)offsetX - 20;
        int rows = 6;
         
        float initialX = -cols / 2 * offsetX;
        float x = initialX;
        float y = 0;
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                Vector2 v = new Vector2(x, y);
      
                GameObject newBrick = (GameObject)Instantiate(brickPrefab, v, Quaternion.identity);
                
                x += offsetX;
            }            
            x = initialX;
            y -= offsetY;            
        }
        
        //Hide our prefab
        brickPrefab.SetActive(false);
        
    }
}
