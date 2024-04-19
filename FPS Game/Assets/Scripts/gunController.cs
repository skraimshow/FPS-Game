using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.UI;

public class gunController : MonoBehaviour
{
    public GameObject Laser; // Our laser kill trigger object
    public Animator gunAnim; // Our gun's Animator
    public int currentAmmo, maxAmmo; // the amount of ammo the gun currently has , -maxAmmo the maximum amount of ammo the gun have
    public AudioSource shootSound; // the sound of the shoot
    public Text ammoText; // display the current ammo amount

    private void Start()
    {
        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        ammoText.text = "" + currentAmmo;
        if(currentAmmo > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gunAnim.ResetTrigger("shoot");
                gunAnim.SetTrigger("shoot");
                currentAmmo = currentAmmo - 1;
                Laser.SetActive(true);
                shootSound.Play();
            }
            else
            {
                Laser.SetActive(false);
            }
        }
    }
}
