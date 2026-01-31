using System;
using System.Threading.Tasks;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class SkokCervena : MonoBehaviour
{
    int cislo;
    int nasadit = 0;
    public int pozicecFigurka1 = 0;
    public int pozicecFigutka2 = 0;
    public int pozicecFigurka3 = 0;
    public int pozicecFigurka4 = 0;
    bool safe = false;
    bool figurka1;
    bool figurka2;
    bool figurka3;
    bool figurka4;
    bool uzJsemKlikl = false;

    GameObject Skok(int cislo)
    {
        switch (cislo)
        {
            case 1: return c1;
            case 2: return c2;
            case 3: return c3;
            case 4: return c4;
            case 5: return c5;
            case 6: return c6;
            case 7: return c7;
            case 8: return c8;
            case 9: return c9;
            case 10: return c10;
            case 11: return c11;
            case 12: return c12;
            case 13: return c13;
            case 14: return c14;
            case 15: return c15;
            case 16: return c16;
            case 17: return c17;
            case 18: return c18;
            case 19: return c19;
            case 20: return c20;
            case 21: return c21;
            case 22: return c22;
            case 23: return c23;
            case 24: return c24;
            case 25: return c25;
            case 26: return c26;
            case 27: return c27;
            case 28: return c28;
            case 29: return c29;
            case 30: return c30;
            case 31: return c31;
            case 32: return c32;
            case 33: return c33;
            case 34: return c34;
            case 35: return c35;
            case 36: return c36;
            case 37: return c37;
            case 38: return c38;
            case 39: return c39;
            case 40: return c40;
            case 41: return c41;
            case 42: return c42;
            case 43: return c43;
            case > 43: return c43;
            case -1: return c1spawn;
            case -2: return c2spawn;
            case -3: return c3spawn;
            case -4: return c4spawn;

            default: return null;
        }
    }

    public GameObject cfigurka1;
    public GameObject cfigurka2;
    public GameObject cfigurka3;
    public GameObject cfigurka4;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject c8;
    public GameObject c9;
    public GameObject c10;
    public GameObject c11;
    public GameObject c12;
    public GameObject c13;
    public GameObject c14;
    public GameObject c15;
    public GameObject c16;
    public GameObject c17;
    public GameObject c18;
    public GameObject c19;
    public GameObject c20;
    public GameObject c21;
    public GameObject c22;
    public GameObject c23;
    public GameObject c24;
    public GameObject c25;
    public GameObject c26;
    public GameObject c27;
    public GameObject c28;
    public GameObject c29;
    public GameObject c30;
    public GameObject c31;
    public GameObject c32;
    public GameObject c33;
    public GameObject c34;
    public GameObject c35;
    public GameObject c36;
    public GameObject c37;
    public GameObject c38;
    public GameObject c39;
    public GameObject c40;
    public GameObject c41;
    public GameObject c42;
    public GameObject c43;
    public GameObject c1spawn;
    public GameObject c2spawn;
    public GameObject c3spawn;
    public GameObject c4spawn;
    public GameObject otazka;
    public GameObject ButtonAno;
    public GameObject ButtonNo;
    public GameObject ButtonHodit;

    public async void Ne()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(50);
            otazka.SetActive(false);
            ButtonAno.SetActive(false);
            ButtonNo.SetActive(false);
            safe = false;

            if (HodKostkou.cislo == 6 && HodKostkou.hodnotaKroku >= 1 && HodKostkou.hodnotaKroku < 43 && safe == true)
            {
                for (int j = 6; j > 0; j--)
                {
                    HodKostkou.hodnotaKroku = HodKostkou.hodnotaKroku + 1;
                    HodKostkou.skok = HodKostkou.skok + 1;
                    GameObject cil = Skok(HodKostkou.skok);
                    cfigurka1.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                    await Task.Delay(100);
                }
            }
            safe = true;
        }
    }
    public async void Ano()
    {
        if (HodKostkou.barva == 0)
        {
            HodKostkou.skok = 0;
            nasadit = nasadit++;
            await Task.Delay(50);
            otazka.SetActive(false);
            ButtonAno.SetActive(false);
            ButtonNo.SetActive(false);
            cfigurka1.transform.position = Skok(1).transform.position + new Vector3(0, 0.125f, 0);
            HodKostkou.hodnotaKroku = 1;
            HodKostkou.skok = 1;
            safe = true;

            if (nasadit == 1)
            {
                figurka1 = true;
            }
            if (nasadit == 2)
            {
                figurka2 = true;
            }
            if (nasadit == 3)
            {
                figurka3 = true;
            }
            if (nasadit == 4)
            {
                figurka4 = true;
            }
        }
    }
    public async void Hod6()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(2401);
            if (HodKostkou.cislo == 6)
            {
                otazka.SetActive(true);
                ButtonAno.SetActive(true);
                ButtonNo.SetActive(true);
            }
        }
    }
    public async void SpustPohyb(int krok)
    {
        if (HodKostkou.hodnotaKroku >= 1 && HodKostkou.hodnotaKroku < 43 && safe == true)
        {
            for (int i = HodKostkou.cislo; i > 0; i--)
            {
                HodKostkou.hodnotaKroku = HodKostkou.hodnotaKroku + 1;
                HodKostkou.skok = HodKostkou.skok + 1;
                GameObject cil = Skok(HodKostkou.skok);
                cfigurka1.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                await Task.Delay(100);
            }
        }
        if (HodKostkou.hodnotaKroku >= 43)
        {
            cfigurka1.transform.position = Skok(43).transform.position + new Vector3(0, 0.125f, 0);
        }
    }

    public void Update()
    {
        if (HodKostkou.barva == 0)
        {
            if (Input.GetMouseButtonDown(0) && HodKostkou.cislo > 0)
            {
                Ray paprsek = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit zasah;

                if (Physics.Raycast(paprsek, out zasah))
                {
                    GameObject trefenyObjekt = c1;
                    trefenyObjekt = zasah.collider.gameObject;

                    if (trefenyObjekt == cfigurka1)
                    {
                        //safe = true;
                        uzJsemKlikl = true;
                        SpustPohyb(HodKostkou.cislo);
                    }
                }
            }
        }
    }
}