using System;

namespace JurassicPark
{
    class ZookeeperMain
    {
        static void Main(string[] args)
        {
            Dinosaurs MrBagido = new Dinosaurs();
            MrBagido.name = "Mr. Bagido";
            MrBagido.age = 3;
            MrBagido.species = "T-Rex";
            MrBagido.softness = 4;

            Dinosaurs NiceBoi = new Dinosaurs();
            NiceBoi.name = "Nice Boi";
            NiceBoi.age = 2;
            NiceBoi.species = "Bagaceratops";
            NiceBoi.softness = 2;

            Dinosaurs Smeegol = new Dinosaurs();
            Smeegol.name = "Smeegol";
            Smeegol.age = 4;
            Smeegol.species = "Velociraptor";
            Smeegol.softness = 5;

            Dinosaurs Friend = new Dinosaurs();
            Friend.name = "Friend";
            Friend.age = 2;
            Friend.species = "Agilisaurus";
            Friend.softness = 3;

            Friend.ReleaseBaga();

            Friend.PrintDetails();

        }
    }
}
