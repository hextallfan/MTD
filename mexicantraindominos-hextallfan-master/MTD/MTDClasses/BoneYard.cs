using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    public class BoneYard
    {
        private List<Domino> listOfDominos = new List<Domino>();
        
        //create maxDots for total number of domino values so you can play other games that require different domino values
        public BoneYard(int maxDots)
        {
            for (int side1 = 0; side1 <= maxDots; side1++)
            {
                for (int side2 = side1; side2 <= maxDots; side2++)
                {
                    Domino d = new Domino(side1, side2);
                    listOfDominos.Add(d);
                }
            }
        }

        //Shuffle the dominos in the Boneyard so you get a random domino upon drawing
        public void Shuffle()
        {
            Random gen = new Random();
            for (int i = 0; i < DominosRemaining; i++)
            {
                int rnd = gen.Next(i, DominosRemaining);
                Domino d = listOfDominos[rnd];
                listOfDominos[rnd] = listOfDominos[i];
                listOfDominos[i] = d;
            }
        }

        //Test if the boneyard has no more reamining dominos
        public bool IsEmpty()
        {
            if (DominosRemaining == 0)
                return true;
            else
                return false;
        }

        //return the total count of dominos in the boneyard
        public int DominosRemaining
        {
            get { return listOfDominos.Count; }
        }

        //draw a domino if there are dominos remaining in the boneyard
        public Domino Draw()
        {
            Domino drawDomino = null;
            if (IsEmpty() == false)
            {
                drawDomino = listOfDominos[0];
                listOfDominos.RemoveAt(0);
            }
            return drawDomino;
        }

        //Create an index to hold a domino value
        public Domino this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                else if (index >= listOfDominos.Count)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                return listOfDominos[index];
            }
            set
            {
                listOfDominos[index] = value;
            }
        }

        public override string ToString()
        {
            string str = "";
            foreach (Domino d in listOfDominos)
            {
                str += (d.ToString() + "n");
            }
            return str;
        }
        
    }
}
