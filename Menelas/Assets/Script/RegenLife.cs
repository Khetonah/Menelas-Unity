using UnityEngine;
using System.Collections;

public class RegenLife : MonoBehaviour {

    public GameObject Player;
    public GameObject GainHp;
    private PlatformerCharacter2D playerScript;

	// Use this for initialization
	void Start () {
        playerScript = Player.GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == Player.name)
        {
            playerScript.Life +=1;
            playerScript.UpdateLife();
            playerScript.ShowLifeText(GainHp);
            Destroy(gameObject);
        }
    }
}
