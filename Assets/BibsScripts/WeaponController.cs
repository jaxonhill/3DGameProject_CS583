using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponController : MonoBehaviour
{
    public bool IsAttacking = false;
    public GameObject Sword, Bow;
    public bool CanAttack = true;
    public float SwordCooldown, BowCooldown = 1.0f;
    public int swordDamage;
    public enum CurrWeapon
    {
        sword,
        bow
    }
    public CurrWeapon weapon;

    [Header("Assets")]
    public GameObject m_ArrowPrefab = null;

    public float m_GrabThreshold = 0.15f;
    public Transform m_Start = null;
    public Transform m_End = null;
    public Transform m_Socket = null;

    private Transform m_PullingHand = null;
    private Arrow m_CurrentArrow = null;
    private Animator m_Animator = null;

    private float m_PullValue = 0.0f;

    /*public void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void start()
    {
        StartCoroutine(CreateArrow(0.0f));
    }*/



    private IEnumerator CreateArrow(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);

        GameObject arrowObject = Instantiate(m_ArrowPrefab, m_Socket);

        //arrowObject.transform.localPosition = new Vector3(0, 0, 0.42f);

        //arrowObject.transform.localEulerAngles = Vector3.zero;

        m_CurrentArrow = arrowObject.GetComponent<Arrow>();

    }

    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (CanAttack)
                {
                    if (weapon == CurrWeapon.sword)
                    {
                        SwordAttack();

                    }



                }
            }
            /*else if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                weapon = CurrWeapon.sword;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                weapon = CurrWeapon.bow;
            }*/
            else if (Input.GetMouseButtonDown(1))
            {
                if (CanAttack)
                {
                    if (weapon == CurrWeapon.sword)
                    {
                        DashAttack();

                    }
                }
            }
        }
    }
    public void SwordAttack()
    {
        IsAttacking = true;
        CanAttack = false;
        Animator anim = Sword.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetAttackCooldown());
    }
    public void DashAttack()
    {
        IsAttacking = true;
        CanAttack = false;
        Animator anim = Sword.GetComponent<Animator>();
        anim.SetTrigger("Dash");
        StartCoroutine(ResetAttackCooldown());
    }
    IEnumerator ResetAttackCooldown()
    {
        StartCoroutine(ResetAttackBool());
        float AttackCooldown = 0;
        if (weapon == CurrWeapon.sword)
        {
            AttackCooldown = SwordCooldown;
        }
        else if (weapon == CurrWeapon.bow)
        {
            AttackCooldown += BowCooldown;
        }
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }
    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        IsAttacking = false;
    }


}
