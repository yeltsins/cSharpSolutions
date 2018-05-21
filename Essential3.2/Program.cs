using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(
                new List<Pupil>(){
                new BadPupil()
                , new ExcellentPupil()
                , new GoodPupil()});
            classRoom.ClassRead();
            classRoom.ClassRelax();
            classRoom.ClassStudy();
            classRoom.ClassWrite();
            Console.ReadKey();
        }

        class ClassRoom
        {
            public List<Pupil> Pupils { get; set; }
            public ClassRoom(List<Pupil> pupils)
            {                
                Pupils = pupils;
                for (int i = 0; i < 4-pupils.Count; i++)
                {
                    Pupils.Add((Pupil)Activator
                        .CreateInstance(
                        Assembly.GetAssembly(typeof(Pupil))
                        .GetTypes()
                        .Where(
                            type => type.IsClass && type.IsSubclassOf(typeof(Pupil)))
                            .ToArray()[new Random().Next(2)]));
                }
            }

            public void ClassStudy()
            {
                foreach (var pupil in Pupils)
                {
                    pupil.Study();
                }
            }
            public void ClassRead()
            {
                foreach (var pupil in Pupils)
                {
                    pupil.Read();
                }
            }
            public void ClassWrite()
            {
                foreach (var pupil in Pupils)
                {
                    pupil.Write();
                }
            }
            public void ClassRelax()
            {
                foreach (var pupil in Pupils)
                {
                    pupil.Relax();
                }
            }
        }

        class Pupil
        {
            public virtual void Study() { }
            public virtual void Read() { }            
            public virtual void Write() { }
            public virtual void Relax() { }
        }

        class ExcellentPupil:Pupil
        {
            public override void Study() { Console.WriteLine("5"); }
            public override void Read() { Console.WriteLine("Exc reading"); }
            public override void Write() { Console.WriteLine("Exc writing"); }
            public override void Relax() { Console.WriteLine("Study again"); }
        }

        class GoodPupil : Pupil
        {
            public override void Study() { Console.WriteLine("4"); }
            public override void Read() { Console.WriteLine("Good reading"); }
            public override void Write() { Console.WriteLine("Good writing"); }
            public override void Relax() { Console.WriteLine("Talking"); }
        }

        class BadPupil : Pupil
        {
            public override void Study() { Console.WriteLine("3"); }
            public override void Read() { Console.WriteLine("Bad reading"); }
            public override void Write() { Console.WriteLine("Bad writing"); }
            public override void Relax() { Console.WriteLine("Gaming"); }
        }
    }
}
