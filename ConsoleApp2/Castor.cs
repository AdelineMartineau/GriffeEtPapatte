using System;
using System.Collections.Generic;
using System.Text;

namespace GriffeEtPapatte
{
    class Castor {
        string name_;
        string category_ = "Poids moyen";
        public double hp_ = 800;
        public double attack_ = 100;
        public double megaAttack_ = 250;
        public double defence_ = 20;
        public int level_ = 1;
        public bool estVivant { get { return hp_ > 0; } }

        private Alea alea = new Alea();

        //Constructeur

        public Castor(string name) {
            name_ = name;
        }

        //Méthodes

        public void Description() {
            Console.WriteLine(name_ + " a " + hp_ + "hp" /*+ " et est au niveau " + level_*/);
        }

        public double Attack(Castor castor) {
            if (alea.AleaDix() < 7) {
                castor.hp_ = castor.hp_ - (attack_ - castor.defence_);
            } else {
                return castor.hp_;
            }
            return castor.hp_;
        }

        public double Attack(Chat chat) {
            if (alea.AleaDix() < 7)
            {
                chat.hp_ = chat.hp_ - (attack_ - chat.defence_);
            }
            else
            {
                return chat.hp_;
            }
            return chat.hp_;
        }

        public double LanceSaumon(Castor castor) {
            if (alea.AleaDix() < 8) {
                castor.hp_ = castor.hp_ - (megaAttack_ - castor.defence_);
            } else {
                return castor.hp_;
            }

            return castor.hp_;
        }

        public double LanceSaumon(Chat chat)
        {
            if (alea.AleaDix() < 8)
            {
                chat.hp_ = chat.hp_ - (megaAttack_ - chat.defence_);
            }
            else
            {
                return chat.hp_;
            }

            return chat.hp_;
        }

        public int LevelUp() {
            level_ = level_ + 1;
            hp_ = hp_ + 200;
            attack_ = attack_ * 1.5;
            defence_ = defence_ * 1.6;
            megaAttack_ = megaAttack_ * 1.3;

            return level_;
        }

    }

}


