using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class HodKostkou : MonoBehaviour
{
    public GameObject kostka1;
    public GameObject kostka2;
    public GameObject kostka3;
    public GameObject kostka4;
    public GameObject kostka5;
    public GameObject kostka6;
    public GameObject ButtonHodit;

    public static int cislo = 0;
    public static int barva;
    public static int pocitadlo;
    public static int hodnotaKroku;
    int cervenaHod = 0;

    public async void Hod()
    {
        kostka1.SetActive(false);
        kostka2.SetActive(false);
        kostka3.SetActive(false);
        kostka4.SetActive(false);
        kostka5.SetActive(false);
        kostka6.SetActive(false);

        if (barva == 0)
        {
            for (int i = 0; i < 12; i++)
            {
                cislo = UnityEngine.Random.Range(1, 7);
                ButtonHodit.SetActive(false);

                if (cislo == 1)
                {
                    kostka1.SetActive(true);
                    await Task.Delay(200);
                    kostka1.SetActive(false);
                }

                if (cislo == 2)
                {
                    kostka2.SetActive(true);
                    await Task.Delay(200);
                    kostka2.SetActive(false);
                }

                if (cislo == 3)
                {
                    kostka3.SetActive(true);
                    await Task.Delay(200);
                    kostka3.SetActive(false);
                }

                if (cislo == 4)
                {
                    kostka4.SetActive(true);
                    await Task.Delay(200);
                    kostka4.SetActive(false);
                }

                if (cislo == 5)
                {
                    kostka5.SetActive(true);
                    await Task.Delay(200);
                    kostka5.SetActive(false);
                }

                if (cislo == 6)
                {
                    kostka6.SetActive(true);
                    await Task.Delay(200);
                    kostka6.SetActive(false);
                }
            }

            if (cislo == 1)
            {
                kostka1.SetActive(true);
                await Task.Delay(200);
            }

            if (cislo == 2)
            {
                kostka2.SetActive(true);
                await Task.Delay(200);
            }

            if (cislo == 3)
            {
                kostka3.SetActive(true);
                await Task.Delay(200);
            }

            if (cislo == 4)
            {
                kostka4.SetActive(true);
                await Task.Delay(200);
            }

            if (cislo == 5)
            {
                kostka5.SetActive(true);
                await Task.Delay(200);
            }

            if (cislo == 6)
            {
                kostka6.SetActive(true);
                await Task.Delay(200);
            }

            cervenaHod = cislo;
            barva = 0;
            ButtonHodit.SetActive(true);
            pocitadlo = pocitadlo + 1;
        }
    }
}
