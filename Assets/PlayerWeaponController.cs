using UnityEngine;
using UnityEngine.UI;

public class PlayerWeaponController : MonoBehaviour
{

    public Camera cam;
    public Image weaponHUD;
    public Image weapon;
    public int weaponCounter;
    public float damage = 1f;
    public float range = 100f;
    Sprite[] weaponArray = new Sprite[9];
    Sprite[] weaponHUDArray = new Sprite[9];

    [System.Serializable]
    public class Weapons
    {
        public Sprite shotgun;
        public Sprite pistol;
        public Sprite machineGun;
        public Sprite fowlingPiece;
        public Sprite crossbow;
        public Sprite knife;
        public Sprite dynamite;
        public Sprite cannon;
        public Sprite axe;
    }
    public Weapons weapons;

    [System.Serializable]
    public class WeaponsHUD
    {
        public Sprite shotgun;
        public Sprite pistol;
        public Sprite machineGun;
        public Sprite fowlingPiece;
        public Sprite crossbow;
        public Sprite knife;
        public Sprite dynamite;
        public Sprite cannon;
        public Sprite axe;
    }
    public WeaponsHUD weaponsHUD;

    void Start()
    {
        weaponArray[0] = weapons.shotgun;
        weaponArray[1] = weapons.pistol;
        weaponArray[2] = weapons.machineGun;
        weaponArray[3] = weapons.fowlingPiece;
        weaponArray[4] = weapons.crossbow;
        weaponArray[5] = weapons.knife;
        weaponArray[6] = weapons.dynamite;
        weaponArray[7] = weapons.cannon;
        weaponArray[8] = weapons.axe;

        weaponHUDArray[0] = weaponsHUD.shotgun;
        weaponHUDArray[1] = weaponsHUD.pistol;
        weaponHUDArray[2] = weaponsHUD.machineGun;
        weaponHUDArray[3] = weaponsHUD.fowlingPiece;
        weaponHUDArray[4] = weaponsHUD.crossbow;
        weaponHUDArray[5] = weaponsHUD.knife;
        weaponHUDArray[6] = weaponsHUD.dynamite;
        weaponHUDArray[7] = weaponsHUD.cannon;
        weaponHUDArray[8] = weaponsHUD.axe;

        weapon.sprite = weaponArray[weaponCounter];
        weaponHUD.sprite = weaponHUDArray[weaponCounter];
        weaponHUD.SetNativeSize();
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log("We hit " + hit.transform.name);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetKeyDown("o"))
        {
            if (weaponCounter == 0)
            {
                weaponCounter = 8;
            }
            else
            {
                weaponCounter -= 1;
            }
        } 
        else if (Input.GetKeyDown("p"))
        {
            if (weaponCounter == 8)
            {
                weaponCounter = 0;
            }
            else
            {
                weaponCounter += 1;
            }
        }
        weapon.sprite = weaponArray[weaponCounter];
        weaponHUD.sprite = weaponHUDArray[weaponCounter];
        weaponHUD.SetNativeSize();
    }
}
