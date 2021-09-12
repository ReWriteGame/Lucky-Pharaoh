using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{

    public UnityEvent takeCoinEvent;
    public UnityEvent takeBombEvent;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Bomb2D>())
        {
            takeBombEvent?.Invoke();
            gameObject.GetComponent<Destroyable>().destroy(.1f);
        }
        if (collision.gameObject.GetComponent<Coin2D>())
        {
            takeCoinEvent?.Invoke();
        }
    }
}
