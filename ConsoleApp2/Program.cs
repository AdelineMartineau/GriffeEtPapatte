using System;

namespace GriffeEtPapatte
{
    class Program
    {
        static void Main(string[] args)
        {
            Alea alea = new Alea();
            Console.WriteLine("Bienvenue dans Griffre et Papatte");
            Chat ElPatoune = new Chat("El Patoune");
            Chat Palpatoune = new Chat("Palpatoune");
            Castor Obelix = new Castor("Obelix");
            Castor Totoro = new Castor("Totoro");

            Console.WriteLine("Chat VS Chat");

            ElPatoune.Description();
            Palpatoune.Description();

            while (ElPatoune.estVivant == true && Palpatoune.estVivant == true)
            {
                if (alea.AleaDix() > 8)
                {
                    ElPatoune.LanceCroquette(Palpatoune);
                }
                else
                {
                    ElPatoune.Attack(Palpatoune);
                }

                if (Palpatoune.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        Palpatoune.LanceCroquette(ElPatoune);
                    }
                    else
                    {
                        Palpatoune.Attack(ElPatoune);
                    }
                }

                ElPatoune.Description();
                Palpatoune.Description();

                if (ElPatoune.estVivant == false) Console.WriteLine("Palpatoune est notre vainqueur !");
                if (Palpatoune.estVivant == false) Console.WriteLine("ElPatoune est notre vainqueur !");

            }


            Console.WriteLine("Castor VS Castor");

            Obelix.Description();
            Totoro.Description();

            while (Obelix.estVivant == true && Totoro.estVivant == true)
            {
                if (alea.AleaDix() > 8)
                {
                    Obelix.LanceSaumon(Totoro);
                }
                else
                {
                    Obelix.Attack(Totoro);
                }

                if (Totoro.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        Totoro.LanceSaumon(Obelix);
                    }
                    else
                    {
                        Totoro.Attack(Obelix);
                    }
                }

                Obelix.Description();
                Totoro.Description();

                if (Totoro.estVivant == false) Console.WriteLine("Obelix est notre vainqueur !");
                if (Obelix.estVivant == false) Console.WriteLine("Totoro est notre vainqueur !");

            }

            if (ElPatoune.estVivant && Obelix.estVivant)
            {
                Console.WriteLine("Castor VS Chat");

                ElPatoune.Description();
                Obelix.Description();

                while (ElPatoune.estVivant == true && Obelix.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        ElPatoune.LanceCroquette(Obelix);
                    }
                    else
                    {
                        ElPatoune.Attack(Obelix);
                    }

                    if (Obelix.estVivant == true)
                    {
                        if (alea.AleaDix() > 8)
                        {
                            Obelix.LanceSaumon(ElPatoune);
                        }
                        else
                        {
                            Obelix.Attack(ElPatoune);
                        }
                    }

                    ElPatoune.Description();
                    Obelix.Description();

                    if (Obelix.estVivant == false) Console.WriteLine("ElPatoune est notre grand vainqueur !");
                    if (ElPatoune.estVivant == false) Console.WriteLine("Obelix est notre grand vainqueur !");
                }
            }

            if (ElPatoune.estVivant && Totoro.estVivant)
            {
                Console.WriteLine("Castor VS Chat");

                ElPatoune.Description();
                Totoro.Description();

                while (ElPatoune.estVivant == true && Totoro.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        ElPatoune.LanceCroquette(Totoro);
                    }
                    else
                    {
                        ElPatoune.Attack(Totoro);
                    }

                    if (Totoro.estVivant == true)
                    {
                        if (alea.AleaDix() > 8)
                        {
                            Totoro.LanceSaumon(ElPatoune);
                        }
                        else
                        {
                            Totoro.Attack(ElPatoune);
                        }
                    }

                    ElPatoune.Description();
                    Totoro.Description();

                    if (Totoro.estVivant == false) Console.WriteLine("ElPatoune est notre grand vainqueur !");
                    if (ElPatoune.estVivant == false) Console.WriteLine("Totoro est notre grand vainqueur !");
                }
            }

            if (Palpatoune.estVivant && Totoro.estVivant)
            {
                Console.WriteLine("Castor VS Chat");

                Palpatoune.Description();
                Totoro.Description();

                while (Palpatoune.estVivant == true && Totoro.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        Palpatoune.LanceCroquette(Totoro);
                    }
                    else
                    {
                        Palpatoune.Attack(Totoro);
                    }

                    if (Totoro.estVivant == true)
                    {
                        if (alea.AleaDix() > 8)
                        {
                            Totoro.LanceSaumon(Palpatoune);
                        }
                        else
                        {
                            Totoro.Attack(Palpatoune);
                        }
                    }

                    Palpatoune.Description();
                    Totoro.Description();

                    if (Totoro.estVivant == false) Console.WriteLine("Palpatoune est notre grand vainqueur !");
                    if (Palpatoune.estVivant == false) Console.WriteLine("Totoro est notre grand vainqueur !");
                }
            }

            if (Palpatoune.estVivant && Obelix.estVivant)
            {
                Console.WriteLine("Castor VS Chat");

                Palpatoune.Description();
                Obelix.Description();

                while (Palpatoune.estVivant == true && Obelix.estVivant == true)
                {
                    if (alea.AleaDix() > 8)
                    {
                        Palpatoune.LanceCroquette(Obelix);
                    }
                    else
                    {
                        Palpatoune.Attack(Obelix);
                    }

                    if (Obelix.estVivant == true)
                    {
                        if (alea.AleaDix() > 8)
                        {
                            Obelix.LanceSaumon(Palpatoune);
                        }
                        else
                        {
                            Obelix.Attack(Palpatoune);
                        }
                    }

                    Palpatoune.Description();
                    Obelix.Description();

                    if (Obelix.estVivant == false) Console.WriteLine("Palpatoune est notre grand vainqueur !");
                    if (Palpatoune.estVivant == false) Console.WriteLine("Obelix est notre grand vainqueur !");

                }
            }
            Console.ReadLine();
        }
    }
}
                
    
