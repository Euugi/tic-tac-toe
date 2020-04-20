using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class GraKolkoKrzyzyk
    {
        static void Main()
        {
            string wybor;
            string imie_gracza1, imie_gracza2;
            System.Console.WriteLine("Witaj w grze Kółko i Krzyżyk");
            System.Console.WriteLine("Imię gracza numer 1: ");
            imie_gracza1 = System.Console.ReadLine();
            System.Console.WriteLine("Imię gracza numer 2:");
            imie_gracza2 = System.Console.ReadLine();
            System.Console.WriteLine("Wpisz 'ZASADY' jeśli chcesz poznać zasady gry, jeśli nie to wpisz 'GRAJ'");

            do
            {
                wybor = System.Console.ReadLine();
                if(wybor!="ZASADY" ||wybor!="GRAJ")
                {
                    System.Console.WriteLine("Błędne polecenie, proszę wybrać ponownie.");
                }
                if (wybor == "ZASADY")
                {
                    System.Console.WriteLine("1. Jeśli chcesz postawić znak na danym polu to wpisz numer pola.");
                    System.Console.WriteLine("2. Pola są ponumerowane od lewej do prawej i z góry do dołu.");
                    System.Console.WriteLine("3. Numery pól mają wartości z zakresu 1-9.");
                    System.Console.WriteLine("4. Każdy gracz ma swoją turę.");
                    System.Console.WriteLine("5. Jeśli chcesz grać na czas wpisz 'GRA NA CZAS'.");
                    Gra(imie_gracza1, imie_gracza2);
                }
                else if (wybor == "GRAJ")
                {
                    Gra(imie_gracza1, imie_gracza2);
                }
            } while (wybor != "ZASADY" || wybor != "GRAJ");
        }
        static void Gra(string gracz1, string gracz2)
        {
            string[] tablica = new string[2];
            int warunek = 0;
            char[,] plansza = new char[3,3];
            plansza[0, 0] = ' ';
            plansza[0, 1] = ' ';
            plansza[0, 2] = ' ';
            plansza[1, 0] = ' ';
            plansza[1, 1] = ' ';
            plansza[1, 2] = ' ';
            plansza[2, 0] = ' ';
            plansza[2, 1] = ' ';
            plansza[2, 2] = ' ';
            int numer_pola1 = 0;
            int numer_pola2 = 0;
            System.Console.WriteLine("Czas rozpocząć grę!");
            Wyswietlanie(plansza);
            do
            {
                System.Console.WriteLine("Tura gracza 1 - Wybierz numer pola");
                numer_pola1 = Convert.ToInt32(System.Console.ReadLine());
                    switch (numer_pola1)
                    {
                        case 1:

                            if (plansza[0, 0] == ' ')
                            {
                                plansza[0, 0] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 2:
                            if (plansza[0, 1] == ' ')
                            {
                                plansza[0, 1] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 3:
                            if (plansza[0, 2] == ' ')
                            {
                                plansza[0, 2] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 4:
                            if (plansza[1, 0] == ' ')
                            {
                                plansza[1, 0] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 5:
                            if (plansza[1, 1] == ' ')
                            {
                                plansza[1, 1] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 6:
                            if (plansza[1, 2] == ' ')
                            {
                                plansza[1, 2] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 7:
                            if (plansza[2, 0] == ' ')
                            {
                                plansza[2, 0] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        case 8:
                            if (plansza[2, 1] == ' ')
                            {
                                plansza[2, 1] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;

                        case 9:
                            if (plansza[2, 2] == ' ')
                            {
                                plansza[2, 2] = 'X';
                                Wyswietlanie(plansza);
                                tablica = Weryfikacja(plansza);
                                System.Console.WriteLine(tablica[0]);
                                warunek = Convert.ToInt32(tablica[1]);
                            }
                            else
                            {
                                System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                                numer_pola1 = System.Console.Read();
                            }
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }

                if (warunek == 1)
                {
                    break;
                }

                System.Console.WriteLine("Tura gracza 2 - Wybierz numer pola");
                numer_pola2 = Convert.ToInt32(System.Console.ReadLine());

                switch (numer_pola2)
                {
                    case 1:
                        if (plansza[0, 0] == ' ')
                        {
                            plansza[0, 0] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 2:
                        if (plansza[0, 1] == ' ')
                        {
                            plansza[0, 1] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 3:
                        if (plansza[0, 2] == ' ')
                        {
                            plansza[0, 2] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 4:
                        if (plansza[1, 0] == ' ')
                        {
                            plansza[1, 0] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 5:
                        if (plansza[1, 1] == ' ')
                        {
                            plansza[1, 1] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 6:
                        if (plansza[1, 2] == ' ')
                        {
                            plansza[1, 2] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 7:
                        if (plansza[2, 0] == ' ')
                        {
                            plansza[2, 0] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 8:
                        if (plansza[2, 1] == ' ')
                        {
                            plansza[2, 1] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    case 9:
                        if (plansza[2, 2] == ' ')
                        {
                            plansza[2, 2] = 'O';
                            Wyswietlanie(plansza);
                            tablica = Weryfikacja(plansza);
                            System.Console.WriteLine(tablica[0]);
                            warunek = Convert.ToInt32(tablica[1]);
                        }
                        else
                        {
                            System.Console.WriteLine("To pole jest zajete - wybierz pole jeszcze raz");
                            numer_pola2 = System.Console.Read();
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            } while (warunek != 1);

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Wcisnij dowolny przycisk aby przerwac gre");
            System.Console.ReadKey();
        }
        static string [] Weryfikacja(char[,] tablica)
        {
            string wygrana1 = "Gracz numer 1 wygrał!";
            string wygrana2 = "Gracz numer 2 wygrał!";
            char[,] plansza = new char[2, 2];
            plansza = tablica;
            string[] tab0 = new string[2];
            string[] tab1 = new string[2];
            string[] tab2 = new string[2];
            tab0[0] = null;
            tab0[1] = null;

            tab1[0] = wygrana1;
            tab1[1] = "1";
            tab2[0] = wygrana2;
            tab2[1] = "1";
            if (plansza[0, 0] == 'X' && plansza[0, 1] =='X' && plansza[0, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[1, 0] == 'X' && plansza[1, 1] == 'X' && plansza[1, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[2, 0] == 'X' && plansza[2, 1] == 'X' && plansza[2, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[0, 0] == 'X' && plansza[1, 0] == 'X' && plansza[2, 0] == 'X')
            {
                return tab1;
            }
            if (plansza[0, 1] == 'X' && plansza[1, 1] == 'X' && plansza[2, 1] == 'X')
            {
                return tab1;
            }
            if (plansza[0, 2] == 'X' && plansza[1, 2] == 'X' && plansza[2, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[0, 0] == 'X' && plansza[1, 1] == 'X' && plansza[2, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[2, 0] == 'X' && plansza[1, 1] == 'X' && plansza[0, 2] == 'X')
            {
                return tab1;
            }
            if (plansza[0, 0] == 'O' && plansza[0, 1] == 'O' && plansza[0, 2] == 'O')
            {
                return tab2;
            }
            if (plansza[1, 0] == 'O' && plansza[1, 1] == 'O' && plansza[1, 2] == 'O')
            {
                return tab2;
            }
            if (plansza[2, 0] == 'O' && plansza[2, 1] == 'O' && plansza[2, 2] == 'O')
            {
                return tab2;
            }
            if (plansza[0, 0] == 'O' && plansza[1, 0] == 'O' && plansza[2, 0] == 'O')
            {
                return tab2;
            }
            if (plansza[0, 1] == 'O' && plansza[1, 1] == 'O' && plansza[2, 1] == 'O')
            {
                return tab2;
            }
            if (plansza[0, 2] == 'O' && plansza[1, 2] == 'O' && plansza[2, 2] == 'O')
            {
                return tab2;
            }
            if (plansza[0, 0] == 'O' && plansza[1, 1] == 'O' && plansza[2, 2] == 'O')
            {
                return tab2;
            }
            if (plansza[2, 0] == 'O' && plansza[1, 1] == 'O' && plansza[0, 2] == 'O')
            {
                return tab2;
            }
            return tab0;
        }

        static void Wyswietlanie(char[,]plansza)
        {
            System.Console.WriteLine("          ____________________");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("          |  " + plansza[0, 0] + "  |  " + plansza[0, 1] + "  |  " + plansza[0, 2] + "  |");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("          |  " + plansza[1, 0] + "  |  " + plansza[1, 1] + "  |  " + plansza[1, 2] + "  |");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("          |  " + plansza[2, 0] + "  |  " + plansza[2, 1] + "  |  " + plansza[2, 2] + "  |");
            System.Console.WriteLine("          ____________________");
        }
    }


}
