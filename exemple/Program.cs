const int Limite = 100;
const int ParLigne = 5;
int compteur = 0;
for (int nombre = 0; nombre < Limite; nombre += 2)
{
    Console.Write($"{nombre,4}");
    compteur++;
    if (compteur % ParLigne == 0) Console.WriteLine();
}