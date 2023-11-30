using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_fläche;

public class Rechteck
{
    public double Länge { get; set; }

    public double Breite { get; set; }

    // in C# gibt es die Möglichkeit Eigenschaften zu verwenden
    // andere Prográmmiersprachen kennen dieses Prinzip nicht und verwenden daher
    // Methoden. Die get-Eigenschaft Fläche wird daher in anderen Sprachen
    // mit geFläche umgesetzt.

    /// <summary>
    /// Berechnet die Fläche des Rechtecks
    /// </summary>
    /// <returns>Gibt den Flächeninhalt zurück</returns>
    public double GetFläche()
    {
        return this.Länge * this.Breite;
    }

    // Falls die Methode "Rechteck()" vorhanden ist, wird die Methode
    // verwendet. Ansonsten wird diese spezielle Methode, bei Abwesenheit
    // eines anderen Konstruktors hinzugefügt.
    // Wir erstellen den Standartkonstruktor immer dann, wenn bestimmte
    // Defaultwerte (Standartwerte) festgelegt werden sollen (z.B. Ort)
    /*
     * Derzeit nicht gewünscht - es soll kein Rechteck ohne Länge und Breite definiert
     * werden können.
    public Rechteck()
    {

    }
    */

    // Bei der Erstellung eines Objektes wird der Konstruktor (Erbauer) aufgerufen.
    // Der Standartkonstruktor hat keinen Parameter und wird automatisch bei einer KLasse, falls kein
    // anderer Konstruktor vorhanden ist, hinzugefügt.
    public Rechteck(double länge, double breite)
    {
        this.Länge = länge;
        this.Breite = breite;
    }
}
