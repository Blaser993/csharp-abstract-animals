// See https://aka.ms/new-console-template for more information
using csharp_abstract_animals;

Console.WriteLine("Hello, World!");

/*
 *Esercizio 1 : classi astratte
Dobbiamo realizzare un programma che rappresenti il regno animale.
Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
Vogliamo che gli animali abbiano i seguenti metodi
void Dormi() (mostra a video “Zzz”)
void Verso() (mostra a video il verso fatto dall'animale specifico)
void CosaMangi() (mostra a video quello che mangia : erba, carne, ...?)
Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
*/

List<Animale> Zoo = new List<Animale>();

Zoo.Add(new Aquila());
foreach (Animale animale in Zoo)
{
    Console.WriteLine($"Animale {animale.Name}");
    animale.CosaMangi();
    animale.Verso();
    animale.Dormi();

    Console.WriteLine();

}


/*
 * Esercizio 2 : interfacce
Alcuni degli animali che abbiamo creato volano, altri nuotano.
Gli animali che volano hanno il seguente metodo :
void Vola() (mostra a video “Sto volando!!!”)
Gli animali che nuotano hanno il seguente metodo :
void Nuota() (mostra a video “Sto nuotando!!!”)
Scrivere un programma avente 2 metodi :
void FaiVolare(IVolante animale)
void FaiNuotare(INuotante animale)
Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro l'animale corretto.
Buon lavoro! :)
*/