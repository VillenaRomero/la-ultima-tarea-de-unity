using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontrol : MonoBehaviour
{
    private Rigibody2D _compRigibody
        public float speedY;
    public GameManagerControl gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        _comRigibody = GetComponet<Rigybody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _compRigibody.velocity = new Vector(0, speedY);
    }
    private voidOntriggerEnter2D(collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            gameManager.updatePoints(20);
            Destroy(this.gameObject);
        }
    }
    public void SetGameMnafer(GameMnagerControl gm) {
        gameMnager = gm;
    }
}
