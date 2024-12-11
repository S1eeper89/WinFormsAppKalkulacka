﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppKalkulacka
{
    // Definice třídy spravující operace naší kalkulačky.

    public class Kalkulacka
    {
        // Soukromá proměnná uchovávající aktuální výsledek výpočtu uvnitř třídy, omezující možnost do ní zasahovat vně.
        private double Result;

        // Konstruktor třídy, který inicializuje počáteční výsledek (defaultně 0).
        public Kalkulacka(double result = 0)
        {
            Result = result;
        }


        public void NastavVysledek(double hodnota)
        {
            Result = hodnota;
        }

        // Metoda vracející aktuální výsledek.
        public double VratAktualniVysledek()
        {
            return Result;
        }

        //metoda cistici aktualni vysledek
        public double VycistiAktualniVysledek()
        {
            return Result = 0;
        }

        // Statická metoda, která ověřuje, zda je zadaný operátor platný.
        public static bool JePlatnyOperator(string vstupOperator)
        {
            // Kontrola, zda je zadaný operátor jedním z povolených: +, -, *, /, ^, x.
            if (vstupOperator == "+" || vstupOperator == "-" || vstupOperator == "*" || vstupOperator == "/" || vstupOperator == "^" || vstupOperator.ToLower() == "x")
            {
                return true;
            }
            else return false;
        }

        // Metoda pro sčítání aktuálního výsledku s druhým číslem.
        public void Secti(double druheCislo)
        {
            Result += druheCislo;
        }

        // Zjednodušená metoda pro odečítání druhého čísla od aktuálního výsledku.
        public void Odecti(double druheCislo)
        {
            Result -= druheCislo;
        }

        // Metoda pro násobení aktuálního výsledku druhým číslem.
        public void Nasob(double druheCislo)
        {
            Result *= druheCislo;
        }

        // Metoda pro dělení aktuálního výsledku druhým číslem.
        public void Del(double druheCislo)
        {
            Result /= druheCislo;
        }

        // pridal bych rozhodne math, pokud bych implementoval, ale ze sentimentu nechavam
        //// Metoda pro umocnění aktuálního výsledku druhým číslem (mocnitelem)
        //public void Umocni(double mocnitel)
        //{
        //    // Speciální případ mocnění nulou
        //    if (mocnitel == 0)
        //    {
        //        Result = 1;
        //    }
        //    else
        //    {
        //        // Uložení výsledku
        //        double mocnenec = Result;
        //        // Inicializace výsledku pro mocnění
        //        Result = 1;
        //        // For cyklus pro výpočet mocniny
        //        for (int i = 1; i <= (int)mocnitel; i++)
        //        {
        //            Result *= mocnenec;
        //        }
        //    }
        //}

        // metoda zaokrouhlí na dvě desetinná místa
        public void ZaokrouhliNaDveDesetinnaMista()
        {
            Result = Math.Round(Result, 2);
        }


    }
}
