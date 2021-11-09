using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using Platformer.Model;
using TMPro;
using System.Threading.Tasks;
using Platformer.Mechanics;
using Platformer.UI;

public class UltimateClickStrike : MonoBehaviour
{
    [SerializeField] private int strikeCost = 1;
    [SerializeField] private int strikeCooldown = 3;
    [SerializeField] private KeyCode strikeBind = KeyCode.Mouse0;
    [SerializeField] private LayerMask layermask;

    [SerializeField] private ParticleSystem particle;
    [SerializeField] private AudioClip hitSound;

    [SerializeField] private bool canStrike;
    void Start()
    {
        canStrike = true;
    }

    // Update is called once per frame
    void Update()
    {
        StrikeStateCheck();
        if (Input.GetKeyDown(strikeBind))
        {
            Strike();
        }
    }
    void Strike()
    {
        if (!canStrike) { return; }
        if (GameDatabase.Instance.CurrentUser.Tokens < strikeCost) { return; }

        if (!GetComponent<Camera>()) { Debug.Log("No camera component!!!"); return; }


        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(point, Vector2.zero, 100, layermask);

        if (hit)
        {
            Instantiate(particle, hit.collider.transform.position,Quaternion.identity).Play();
            //Debug.Log(hit.collider.transform.position);
            if (hit.collider.gameObject.GetComponent<EnemyController>())
            {
                hit.collider.gameObject.GetComponent<AudioSource>().clip = hitSound;
                hit.collider.gameObject.GetComponent<AudioSource>().Play();
                Destroy(hit.collider.gameObject, 0.3f);
                GameDatabase.Instance.CurrentUser.EnemiesKilled++;              
            } 
        }


        canStrike = false;
        StartCoroutine("StrikeCooldown");

        GameDatabase.Instance.CurrentUser.Tokens -= strikeCost;
    }

    IEnumerator StrikeCooldown()
    {
        yield return new WaitForSeconds(strikeCooldown);
        canStrike = true;
    }

    private void StrikeStateCheck()
    {
        if(GameDatabase.Instance.CurrentUser.Tokens >= strikeCost && canStrike)
        {
            LevelCanvas.Instance.UltimateStrikeState(true);
        }
        else
        {
            LevelCanvas.Instance.UltimateStrikeState(false);
        }
    }
}
