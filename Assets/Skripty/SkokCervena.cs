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
    //když hodim 6 tak se pohnu a taky muzu nasadit, pøerollování kostky
    int cislo;
    public static int nasadit = 0;
    public int pozicecFigurka1 = 0;
    public int pozicecFigutka2 = 0;
    public int pozicecFigurka3 = 0;
    public int pozicecFigurka4 = 0;
    bool figurka1 = false;
    bool figurka2 = false;
    bool figurka3 = false;
    bool figurka4 = false;

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
            case 44: return c44;
            case > 43: return c44;
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
    public GameObject c44;
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
        await Task.Delay(100);
        if (HodKostkou.barva == 0)
        {
            otazka.SetActive(false);
            ButtonAno.SetActive(false);
            ButtonNo.SetActive(false);
            HodKostkou.safe = true;
        }
    }
    
    public async void Ne1()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(100);

            if (HodKostkou.hodnotaKroku1c >= 1 && HodKostkou.hodnotaKroku1c < 44 && HodKostkou.domecek1 == false)
            {
                for (int j = 6; j > 0; j--)
                {
                    HodKostkou.hodnotaKroku1c = HodKostkou.hodnotaKroku1c + 1;
                    HodKostkou.skok1c = HodKostkou.skok1c + 1;
                    GameObject cil = Skok(HodKostkou.skok1c);
                    cfigurka1.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                    await Task.Delay(150);
                }
                if (HodKostkou.hodnotaKroku1c >= 44 - HodKostkou.domecek && figurka1 == false && HodKostkou.domecek1 == false)
                {
                    cfigurka1.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                    figurka1 = true;
                    HodKostkou.domecek1 = true;
                    HodKostkou.domecek = HodKostkou.domecek + 1;
                }
            }
        }
    }
    public async void Ne2()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(100);

            if (HodKostkou.hodnotaKroku2c >= 1 && HodKostkou.hodnotaKroku2c < 44 && HodKostkou.domecek2 == false)
            {
                for (int j = 6; j > 0; j--)
                {
                    HodKostkou.hodnotaKroku2c = HodKostkou.hodnotaKroku2c + 1;
                    HodKostkou.skok2c = HodKostkou.skok2c + 1;
                    GameObject cil = Skok(HodKostkou.skok2c);
                    cfigurka2.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                    await Task.Delay(150);
                }
                HodKostkou.safe = false;
                if (HodKostkou.hodnotaKroku3c >= 44 - HodKostkou.domecek && figurka2 == false && HodKostkou.domecek2 == false)
                {
                    cfigurka2.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                    figurka2 = true;
                    HodKostkou.domecek3 = true;
                    HodKostkou.domecek = HodKostkou.domecek + 1;
                }
            }
        }
    }
    public async void Ne3()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(100);

            if (HodKostkou.hodnotaKroku3c >= 1 && HodKostkou.hodnotaKroku3c < 44 && HodKostkou.domecek3 == false)
            {
                for (int j = 6; j > 0; j--)
                {
                    HodKostkou.hodnotaKroku3c = HodKostkou.hodnotaKroku3c + 1;
                    HodKostkou.skok3c = HodKostkou.skok3c + 1;
                    GameObject cil = Skok(HodKostkou.skok3c);
                    cfigurka3.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                    await Task.Delay(150);
                }
                if (HodKostkou.hodnotaKroku3c >= 44 - HodKostkou.domecek && figurka3 == false && HodKostkou.domecek3 == false)
                {
                    cfigurka3.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                    figurka3 = true;
                    HodKostkou.domecek3 = true;
                    HodKostkou.domecek = HodKostkou.domecek + 1;
                }
            }
        }
    }
    public async void Ne4()
    {
        if (HodKostkou.barva == 0)
        {
            await Task.Delay(100);

            if (HodKostkou.hodnotaKroku4c >= 1 && HodKostkou.hodnotaKroku4c < 44 && HodKostkou.domecek4 == false)
            {
                for (int j = 6; j > 0; j--)
                {
                    HodKostkou.hodnotaKroku4c = HodKostkou.hodnotaKroku4c + 1;
                    HodKostkou.skok4c = HodKostkou.skok4c + 1;
                    GameObject cil = Skok(HodKostkou.skok4c);
                    cfigurka4.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                    await Task.Delay(150);
                }
                if (HodKostkou.hodnotaKroku4c >= 44 - HodKostkou.domecek && figurka4 == false && HodKostkou.domecek4 == false)
                {
                    cfigurka4.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                    figurka4 = true;
                    HodKostkou.domecek4 = true;
                    HodKostkou.domecek = HodKostkou.domecek + 1;
                }
            }
        }
    }
    public async void Ano()
    {
        if (HodKostkou.barva == 0)
        {
            HodKostkou.safe = false;
            nasadit = nasadit + 1;
            await Task.Delay(100);
            otazka.SetActive(false);
            ButtonAno.SetActive(false);
            ButtonNo.SetActive(false);

            if (nasadit == 1)
            {
                figurka1 = false;
                HodKostkou.hodnotaKroku1c = 1;
                HodKostkou.skok1c = 1;
                HodKostkou.domecek1 = false;
                cfigurka1.transform.position = Skok(1).transform.position + new Vector3(0, 0.125f, 0);
                ButtonHodit.SetActive(true);

            }
            if (nasadit == 2 && c1.transform.position + new Vector3(0, 0.125f, 0) != cfigurka1.transform.position)
            {
                figurka2 = false;
                HodKostkou.hodnotaKroku2c = 1;
                HodKostkou.skok2c = 1;
                HodKostkou.domecek1 = false;
                cfigurka2.transform.position = Skok(1).transform.position + new Vector3(0, 0.125f, 0);
                ButtonHodit.SetActive(true);
            }
            if (nasadit == 3 && c2.transform.position + new Vector3(0, 0.125f, 0) != cfigurka2.transform.position)
            {
                figurka3 = false;
                HodKostkou.hodnotaKroku3c = 1;
                HodKostkou.skok3c = 1;
                HodKostkou.domecek1 = false;
                cfigurka3.transform.position = Skok(1).transform.position + new Vector3(0, 0.125f, 0);
                ButtonHodit.SetActive(true);
            }
            if (nasadit == 4 && c1.transform.position + new Vector3(0, 0.125f, 0) != cfigurka3.transform.position)
            {
                figurka4 = false;
                HodKostkou.hodnotaKroku4c = 1;
                HodKostkou.skok4c = 1;
                HodKostkou.domecek1 = false;
                cfigurka4.transform.position = Skok(1).transform.position + new Vector3(0, 0.125f, 0);
                ButtonHodit.SetActive(true);
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
            HodKostkou.safe = true;
        }
    }
    public async void SpustPohyb1(int krok)
    {
        if (HodKostkou.hodnotaKroku1c >= 1 && HodKostkou.hodnotaKroku1c < 44 && HodKostkou.domecek1 == false)
        {
            for (int i = HodKostkou.cislo; i > 0; i--)
            {
                HodKostkou.hodnotaKroku1c = HodKostkou.hodnotaKroku1c + 1;
                HodKostkou.skok1c = HodKostkou.skok1c + 1;
                GameObject cil = Skok(HodKostkou.skok1c);
                cfigurka1.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                await Task.Delay(150);
            }
            if (HodKostkou.hodnotaKroku1c >= 44 - HodKostkou.domecek && figurka1 == false && HodKostkou.domecek1 == false)
            {
                cfigurka1.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                figurka1 = true;
                HodKostkou.domecek1 = true;
                HodKostkou.domecek = HodKostkou.domecek + 1;
                Debug.Log(HodKostkou.domecek);
            }
        }
    }
    public async void SpustPohyb2(int krok)
    {
        if (HodKostkou.hodnotaKroku2c >= 1 && HodKostkou.hodnotaKroku2c < 44 && HodKostkou.domecek2 == false)
        {
            for (int i = HodKostkou.cislo; i > 0; i--)
            {
                HodKostkou.hodnotaKroku2c = HodKostkou.hodnotaKroku2c + 1;
                HodKostkou.skok2c = HodKostkou.skok2c + 1;
                GameObject cil = Skok(HodKostkou.skok2c);
                cfigurka2.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                await Task.Delay(150);
            }
            if (HodKostkou.hodnotaKroku2c >= 44 - HodKostkou.domecek && figurka2 == false && HodKostkou.domecek2 == false)
            {
                cfigurka2.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                figurka2 = true;
                HodKostkou.domecek2 = true;
                HodKostkou.domecek = HodKostkou.domecek + 1;
            }
        }
    }
    public async void SpustPohyb3(int krok)
    {
        if (HodKostkou.hodnotaKroku3c >= 1 && HodKostkou.hodnotaKroku3c < 44 && HodKostkou.domecek3 == false)
        {
            for (int i = HodKostkou.cislo; i > 0; i--)
            {
                HodKostkou.hodnotaKroku3c = HodKostkou.hodnotaKroku3c + 1;
                HodKostkou.skok3c = HodKostkou.skok3c + 1;
                GameObject cil = Skok(HodKostkou.skok3c);
                cfigurka3.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                await Task.Delay(150);
            }
            if (HodKostkou.hodnotaKroku3c >= 44 - HodKostkou.domecek && figurka3 == false && HodKostkou.domecek3 == false)
            {
                cfigurka3.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                figurka3 = true;
                HodKostkou.domecek3 = true;
                HodKostkou.domecek = HodKostkou.domecek + 1;
            }
        }
    }
    public async void SpustPohyb4(int krok)
    {
        if (HodKostkou.hodnotaKroku4c >= 1 && HodKostkou.hodnotaKroku4c < 44 && HodKostkou.domecek4 == false)
        {
            HodKostkou.safe = false;
            for (int i = HodKostkou.cislo; i > 0; i--)
            {
                HodKostkou.hodnotaKroku4c = HodKostkou.hodnotaKroku4c + 1;
                HodKostkou.skok4c = HodKostkou.skok4c + 1;
                GameObject cil = Skok(HodKostkou.skok4c);
                cfigurka4.transform.position = cil.transform.position + new Vector3(0, 0.125f, 0);
                await Task.Delay(150);
            }
            if (HodKostkou.hodnotaKroku4c >= 44 - HodKostkou.domecek && figurka4 == false && HodKostkou.domecek4 == false)
            {
                cfigurka4.transform.position = Skok(44 - HodKostkou.domecek).transform.position + new Vector3(0, 0.125f, 0);
                figurka4 = true;
                HodKostkou.domecek4 = true;
                HodKostkou.domecek = HodKostkou.domecek + 1;
            }
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

                    if (trefenyObjekt == cfigurka1 && HodKostkou.safe == true)
                    {
                        ButtonHodit.SetActive(true);
                        if (HodKostkou.cislo != 6)
                        {
                            SpustPohyb1(HodKostkou.cislo);
                            //HodKostkou.safe = false;
                        }
                        if (HodKostkou.cislo == 6)
                        {
                            Ne1();
                            //HodKostkou.safe = false;
                        }
                    }
                    if (trefenyObjekt == cfigurka2 && HodKostkou.safe == true)
                    {
                        ButtonHodit.SetActive(true);
                        if (HodKostkou.cislo != 6)
                        {
                            SpustPohyb2(HodKostkou.cislo);
                            //HodKostkou.safe = false;
                        }
                        if (HodKostkou.cislo == 6)
                        {
                            Ne2();
                            //HodKostkou.safe = false;
                        }
                    }
                    if (trefenyObjekt == cfigurka3 && HodKostkou.safe == true)
                    {
                        ButtonHodit.SetActive(true);
                        if (HodKostkou.cislo != 6)
                        {
                            SpustPohyb3(HodKostkou.cislo);
                            //HodKostkou.safe = false;
                        }
                        if (HodKostkou.cislo == 6)
                        {
                            Ne3();
                            //HodKostkou.safe = false;
                        }
                    }
                    if (trefenyObjekt == cfigurka4 && HodKostkou.safe == true)
                    {
                        ButtonHodit.SetActive(true);
                        if (HodKostkou.cislo != 6)
                        {
                            SpustPohyb4(HodKostkou.cislo);
                            //HodKostkou.safe = false;
                        }
                        if (HodKostkou.cislo == 6)
                        {
                            Ne4();
                            //HodKostkou.safe = false;
                        }
                    }
                }
            }
        }
    }
}