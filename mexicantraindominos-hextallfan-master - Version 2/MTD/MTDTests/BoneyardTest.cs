using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MTDClasses;

namespace MTDTests
{
    [TestFixture]
    public class BoneyardTest
    {
        [Test]
        public void TestConstructor()
        {
            //Test the constructors
            BoneYard b6 = new BoneYard(6);
            Assert.AreEqual(28, b6.DominosRemaining);
            Assert.AreEqual(new Domino(0, 0), b6[0]);
            Assert.AreEqual(new Domino(6, 6), b6[27]);
            Assert.AreEqual(new Domino(1, 1), b6[7]);
        }

        [Test]
        public void TestBoneYardShuffle()
        {
            //Test my shuffle by drawing a domino and then shuffling and the drawn domino is not the first domino created  
            BoneYard b = new BoneYard(12);
            Assert.AreEqual(new Domino(0, 0), b.Draw());
            b.Shuffle();
            Assert.False(new Domino(0, 0) == b.Draw());
        }

        [Test]
        public void TestBoneYardIsEmpty()
        {
            //Test that the boneyard is not empty
            BoneYard d = new BoneYard(12);
            Assert.False(d.IsEmpty());
        }

        [Test]
        public void TestBoneYardDraw()
        {
            //Testing if Draw() gets a return domino
            BoneYard b = new BoneYard(12);
            Assert.AreEqual(new Domino(0, 0), b.Draw());
        }

        [Test]
        public void TestBoneYardDominosRemaining()
        {
            //Testing if the DominosRemaining count returns a positive integer
            BoneYard b6 = new BoneYard(6);
            Assert.Greater(b6.DominosRemaining, 0);
        }
        [Test]
        /*public void TestBoneYardIndexer()
        {
            //Testing return of indexer 
            BoneYard b = new BoneYard(index);
            index = this.BoneYard();
            Assert.AreEqual(b, index);
        }*/
    }
}
