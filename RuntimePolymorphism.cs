using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    namespace ConsoleApp16
    {

        class TataCar
        {
            //Dependency
            
            public void Ignite(Engine _engineType)
            {
                _engineType.Start();
            }
            public void Halt(Engine _engineType)
            {
                _engineType.Stop();
            }
        }

        class Engine
        {
            public virtual void Start() { }
            public virtual void Stop() { }

        }
        class RevtronEngine : Engine
        {
            public override void Start()
            {
                Console.WriteLine("Revtron...Ignited");
            }
            public override void Stop() { }
        }
        class VericoreEngine : Engine
        {
            public override void Start()
            {
                Console.WriteLine("Vericore...Ignited");
            }
            public override void Stop() { }

        }
        class KrytoechEngine : Engine
        {
            public override void Start()
            {
                Console.WriteLine("Kryotech...Ignited");
            }
            public override void Stop() { }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                TataCar _nexon = new TataCar();
                Engine rev = new RevtronEngine();
                _nexon.Ignite(rev);

                TataCar _harrier = new TataCar(); //Kryotech engine
                Engine kryo = new KrytoechEngine();
                _harrier.Ignite(kryo);

                TataCar _hexa = new TataCar();//vericore engine
                Engine veri = new VericoreEngine();
                _hexa.Ignite(veri);


                FamilyOccassion _family = new FamilyOccassion();
                Parent _parentInstance = new Parent();
                _family.Visit(_parentInstance);

                _parentInstance = new Child_One(); //Runtime Polymorphism
                _family.Visit(_parentInstance);

                _parentInstance = new Child_Two();
                _family.Visit(_parentInstance);

                _parentInstance = new Child_Three();
                _family.Visit(_parentInstance);

            }
        }


        public class FamilyOccassion
        {

            public void Visit(Parent familyMember)
            {
                familyMember.Participate(); //Runtime Polymorphism

            }

        }

        public class Parent
        {

            public virtual void Participate()
            {
                Console.WriteLine("Parent ...Participate ");
            }
        }
        public class Child_One : Parent
        {

            public override void Participate()
            {
                Console.WriteLine("ChildOne...Participate");
            }
            public void Smoke()
            {

            }
        }
        public class Child_Two : Parent
        {

            public override void Participate()
            {
                Console.WriteLine("ChildTwo...Participate");
            }

        }
        public class Child_Three : Parent
        {
            public override void Participate()
            {
                Console.WriteLine("ChildThree...Participate");
            }

        }



    }
}
